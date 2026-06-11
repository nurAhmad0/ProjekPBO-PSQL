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
    public partial class FormTambahJadwalFarmer : Form
    {
        (string tipeJadwal, string template) infoJadwal;
        JadwalController jadwalController = new JadwalController();
        PenanamanLahanController penanamanController = new PenanamanLahanController();
        LahanController lahanController = new LahanController();
        TanamanController tanamanController = new TanamanController();
        public FormTambahJadwalFarmer((string tipeJadwal, string template) infoJadwal)
        {
            InitializeComponent();
            this.infoJadwal = infoJadwal;
            IsiComboBoxLahanDanTanaman();
            if (infoJadwal.template == "Panen")
            {
                txtKeterangan.ReadOnly = false;
                cbTanaman.Enabled = false;
            }
            if (infoJadwal.template == "Lainnya")
            {
                cbTanaman.Enabled = false;
            }
            if (infoJadwal.template == "Menanam")
            {
                txtKeterangan.ReadOnly = false;
            }
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahJadwal_Load(object sender, EventArgs e)
        {

        }

        private void IsiComboBoxLahanDanTanaman()
        {
            try
            {
                List<Lahan> daftarLahan = lahanController.GetAllLahan();
                List<Lahan> lahanAktif = daftarLahan.FindAll(l => l.getStatusLahan() == "Aktif");

                cbLahan.DataSource = lahanAktif;
                cbLahan.DisplayMember = "DisplayLahan"; 
                cbLahan.ValueMember = "id_Lahan";     
                List<Tanaman> daftarTanaman = tanamanController.GetAllTanaman();

                cbTanaman.DataSource = daftarTanaman;
                cbTanaman.DisplayMember = "nama_tanaman"; 
                cbTanaman.ValueMember = "id_tanaman";     
                cbLahan.SelectedIndex = -1;
                cbTanaman.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data komponen: " + ex.Message, "Error Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cbLahan.SelectedIndex == -1 || cbLahan.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih Lahan terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbTanaman.SelectedIndex == -1 || cbTanaman.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih Jenis Tanaman terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Validator.ApakahKosong(txtKeterangan.Text))
            {
                MessageBox.Show("Keterangan kegiatan tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKeterangan.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtJumlahDitanam.Text))
            {
                MessageBox.Show("Jumlah tanaman yang ditanam tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahDitanam.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtJumlahAnggota.Text))
            {
                MessageBox.Show("Banyaknya anggota tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahAnggota.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtTotalUpah.Text))
            {
                MessageBox.Show("Total upah tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalUpah.Focus();
                return;
            }

            if (!int.TryParse(txtJumlahDitanam.Text.Trim(), out int jumlahDitanam) || jumlahDitanam <= 0)
            {
                MessageBox.Show("Jumlah ditanam harus berupa angka bulat dan lebih dari 0!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahDitanam.Focus();
                return;
            }

            if (!int.TryParse(txtJumlahAnggota.Text.Trim(), out int jumlahAnggota) || jumlahAnggota <= 0)
            {
                MessageBox.Show("Jumlah anggota harus berupa angka bulat dan lebih dari 0!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahAnggota.Focus();
                return;
            }

            if (!decimal.TryParse(txtTotalUpah.Text.Trim(), out decimal totalUpah) || totalUpah < 0)
            {
                MessageBox.Show("Total upah harus berupa angka nominal yang valid!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalUpah.Focus();
                return;
            }

            try
            {
                int idLahanTerpilih = (int)cbLahan.SelectedValue;
                DateTime tanggalKegiatan = dtpTanggal.Value.Date;
                string namaTanamanJadwal = (infoJadwal.template == "Panen") ? "Panen" : cbTanaman.Text;

                JadwalFarmer jadwalFarmerBaru = new JadwalFarmer(0,tanggalKegiatan,txtKeterangan.Text.Trim(),jumlahAnggota,"Belum Dikerjakan",cbLahan.Text,namaTanamanJadwal,tanggalKegiatan,jumlahDitanam,idLahanTerpilih,totalUpah);

                bool isSukses = false;
                if (infoJadwal.template == "Menanam")
                {
                    int idTanamanTerpilih = (int)cbTanaman.SelectedValue;
                    Lahan dummyLahan = new Lahan(idLahanTerpilih, cbLahan.Text, 0, "Aktif");
                    Tanaman dummyTanaman = new Tanaman(idTanamanTerpilih, cbTanaman.Text, 0, 0);

                    PenanamanLahan penanamanBaru = new PenanamanLahan(0, tanggalKegiatan, jumlahDitanam, "Masih Ditanam", dummyLahan, dummyTanaman);
                    bool isSuksesJadwal = jadwalController.tambahJadwal(jadwalFarmerBaru);
                    bool isSuksesLahan = penanamanController.TambahTanamanLahan(penanamanBaru);
                    if (isSuksesJadwal & isSuksesLahan)
                    {
                        isSukses = true;
                    }
                }
                else if (infoJadwal.template == "Panen" || infoJadwal.template == "Lainnya")
                {
                    isSukses = jadwalController.tambahJadwal(jadwalFarmerBaru);
                }
                if (isSukses)
                {
                    MessageBox.Show($"Jadwal {infoJadwal.template} berhasil disimpan ke sistem!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKeterangan.Clear();
                    txtJumlahDitanam.Clear();
                    txtJumlahAnggota.Clear();
                    txtTotalUpah.Clear();
                    cbLahan.SelectedIndex = -1;
                    cbTanaman.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi masalah saat memproses data: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}