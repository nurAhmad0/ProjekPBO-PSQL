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
    public partial class FormTambahJadwalPengantaran : Form
    {
        JadwalController jadwalController = new JadwalController();
        TanamanController tanamanController = new TanamanController();
        PelangganController pelangganController = new PelangganController();

        public FormTambahJadwalPengantaran()
        {
            InitializeComponent();
            //IsiComboBoxLahanDanTanaman();
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

                cbTanaman.DataSource = lahanAktif;
                cbTanaman.DisplayMember = "DisplayLahan"; 
                cbTanaman.ValueMember = "id_Lahan";     
                List<Tanaman> daftarTanaman = tanamanController.GetAllTanaman();

                cbPelanggan.DataSource = daftarTanaman;
                cbPelanggan.DisplayMember = "nama_tanaman"; 
                cbPelanggan.ValueMember = "id_tanaman";     
                cbTanaman.SelectedIndex = -1;
                cbPelanggan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data komponen: " + ex.Message, "Error Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cbTanaman.SelectedIndex == -1 || cbTanaman.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih Lahan terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbPelanggan.SelectedIndex == -1 || cbPelanggan.SelectedValue == null)
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

            if (Validator.ApakahKosong(txtJumlahDibeli.Text))
            {
                MessageBox.Show("Jumlah tanaman yang ditanam tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahDibeli.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtTotalUpah.Text))
            {
                MessageBox.Show("Total upah tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalUpah.Focus();
                return;
            }

            if (!int.TryParse(txtJumlahDibeli.Text.Trim(), out int jumlahDitanam) || jumlahDitanam <= 0)
            {
                MessageBox.Show("Jumlah ditanam harus berupa angka bulat dan lebih dari 0!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahDibeli.Focus();
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
                int idLahanTerpilih = (int)cbTanaman.SelectedValue;
                bool isSukses = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi masalah saat memproses data: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}