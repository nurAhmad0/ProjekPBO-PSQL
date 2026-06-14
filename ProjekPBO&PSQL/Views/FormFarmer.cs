using ProjekPBO_PSQL.Controllers;
using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormFarmer : Form
    {
        OrangController controllersOrang = new OrangController();
        JadwalController controllersJadwal = new JadwalController();
        int idFarmer;
        public FormFarmer(int id)
        {
            InitializeComponent();
            this.idFarmer = id;
            Orang farmer = controllersOrang.Cari(id)!;
            lblNama.Text = farmer.getName();
            lbSaldo.Text = farmer.getSaldo().ToString("N0");
            panelJadwal.Visible = true;
        }
        private void FormFarmer_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void btnPlus50k_Click(object sender, EventArgs e)
        {
            decimal nominal = string.IsNullOrEmpty(txtNominalTarik.Text) ? 0 : Convert.ToDecimal(txtNominalTarik.Text);
            nominal += 50000;
            txtNominalTarik.Text = nominal.ToString();
        }
        private void btnMinus50k_Click(object sender, EventArgs e)
        {
            decimal nominal = string.IsNullOrEmpty(txtNominalTarik.Text) ? 0 : Convert.ToDecimal(txtNominalTarik.Text);
            txtNominalTarik.Text = (nominal >= 50000) ? (nominal - 50000).ToString() : "0";
        }

        private void btnPlus100k_Click(object sender, EventArgs e)
        {
            decimal nominal = string.IsNullOrEmpty(txtNominalTarik.Text) ? 0 : Convert.ToDecimal(txtNominalTarik.Text);
            nominal += 100000;
            txtNominalTarik.Text = nominal.ToString();
        }
        private void btnMinus100k_Click(object sender, EventArgs e)
        {
            decimal nominal = string.IsNullOrEmpty(txtNominalTarik.Text) ? 0 : Convert.ToDecimal(txtNominalTarik.Text);
            txtNominalTarik.Text = (nominal >= 100000) ? (nominal - 100000).ToString() : "0";
        }
        private void PindahPanel(Panel panelTarget, string judul)
        {
            panelJadwal.Visible = false;
            panelPenarikanSaldo.Visible = false;
            panelHistoriPenarikan.Visible = false;
            panelLaporan.Visible = false;

            panelTarget.Visible = true;
            panelTarget.BringToFront();
        }

        private void btnNavJadwal_Click(object sender, EventArgs e)
        {
            PindahPanel(panelJadwal, "Jadwal");
            try
            {
                DataTable dtJadwal = controllersJadwal.GetAllJadwalFarmerHariIni();
                dgvJadwal.DataSource = dtJadwal;
                dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvJadwal.Columns.Contains("id_jadwal"))
                {
                    dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                    dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                    dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan Kegiatan";
                    dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                    dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Jumlah Pekerja";
                    dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                    dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
                    dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan jadwal hari ini ke tabel: " + ex.Message, "Error Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNavPenarikan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelPenarikanSaldo, "Penarikan Saldo");
        }

        private void btnNavHistori_Click(object sender, EventArgs e)
        {
            PindahPanel(panelHistoriPenarikan, "Histori Penarikan");
        }

        private void btnNavLaporan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelLaporan, "Laporan");
        }

        private void btnTambahLaporan_Click(object sender, EventArgs e)
        {
            //FormLaporanFarmer formLaporan = new FormLaporanFarmer();
            //formLaporan.ShowDialog();
        }

        private void dgvJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPilihJadwal_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris karyawan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int sisaKuota = Convert.ToInt32(dgvJadwal.CurrentRow.Cells["banyaknya_anggota"].Value);

            if (sisaKuota <= 0)
            {
                MessageBox.Show("Maaf, kuota pekerja untuk jadwal ini sudah penuh!", "Kuota Habis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTerpilih = Convert.ToInt32(dgvJadwal.CurrentRow.Cells["ID Jadwal"].Value);
                JadwalFarmer JadwalTerpilih = controllersJadwal.GetAllJadwalFarmer(idTerpilih)!;
                if (JadwalTerpilih == null)
                {
                    MessageBox.Show("Data Jadwal tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool hasil = controllersJadwal.TambahDetailJadwal(idFarmer, idTerpilih);
                if (hasil)
                {
                    MessageBox.Show("Berhasil bergabung ke dalam jadwal pekerjaan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal bergabung ke dalam jadwal.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}
