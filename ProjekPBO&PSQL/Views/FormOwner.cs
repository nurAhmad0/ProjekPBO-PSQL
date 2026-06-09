using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormOwner : Form
    {
        public FormOwner()
        {
            InitializeComponent();
        }

        private void dgvLahan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelKaryawan, "Karyawan");
        }

        private void btnLahan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelLahan, "Lahan");
        }

        private void btnTanaman_Click(object sender, EventArgs e)
        {
            PindahPanel(panelTanaman, "Tanaman");
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            PindahPanel(panelJadwal, "Jadwal");
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelPelanggan, "Pelanggan");
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelLaporan, "Laporan");
        }
        // Add/Edit
        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            FormTambahKaryawan popUpTambah = new FormTambahKaryawan();
            popUpTambah.ShowDialog();
        }
        private void btnEditKaryawan_Click(object sender, EventArgs e)
        {
            if (dgvKaryawan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris karyawan terlebih dahulu!", "Peringatan");
                return;
            }

            FormEditKaryawan popUpEdit = new FormEditKaryawan();
            popUpEdit.txtIdAnggota.Text = dgvKaryawan.CurrentRow.Cells["colIdAnggota"].Value.ToString();
            popUpEdit.txtNama.Text = dgvKaryawan.CurrentRow.Cells["colNamaAnggota"].Value.ToString();
            popUpEdit.txtNoTelp.Text = dgvKaryawan.CurrentRow.Cells["colNoTelp"].Value.ToString();
            popUpEdit.dtpTanggalLahir.Value = Convert.ToDateTime(dgvKaryawan.CurrentRow.Cells["colTanggalLahir"].Value);
            popUpEdit.txtEmail.Text = dgvKaryawan.CurrentRow.Cells["colEmail"].Value.ToString();
            popUpEdit.cbStatusKerja.Text = dgvKaryawan.CurrentRow.Cells["colStatusKerja"].Value.ToString();
            popUpEdit.txtSaldo.Text = dgvKaryawan.CurrentRow.Cells["colSaldo"].Value.ToString();
            popUpEdit.txtUsername.Text = dgvKaryawan.CurrentRow.Cells["colUsername"].Value.ToString();
            popUpEdit.txtPassword.Text = dgvKaryawan.CurrentRow.Cells["colPassword"].Value.ToString();
            popUpEdit.txtIdRole.Text = dgvKaryawan.CurrentRow.Cells["colIdRole"].Value.ToString(); // Menggunakan sistem input ID angka langsung

            popUpEdit.ShowDialog();
        }
        private void btnTambahLahan_Click(object sender, EventArgs e)
        {
            FormTambahLahan popUpTambah = new FormTambahLahan();
            popUpTambah.ShowDialog();
        }
        private void btnEditLahan_Click(object sender, EventArgs e)
        {
            if (dgvLahan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris lahan terlebih dahulu!", "Peringatan");
                return;
            }

            FormEditLahan popUpEdit = new FormEditLahan();
            popUpEdit.txtIdLahan.Text = dgvLahan.CurrentRow.Cells["colIdLahan"].Value.ToString();
            popUpEdit.txtNamaLahan.Text = dgvLahan.CurrentRow.Cells["colNamaLahan"].Value.ToString();
            popUpEdit.txtLuasLahan.Text = dgvLahan.CurrentRow.Cells["colLuasLahan"].Value.ToString();
            popUpEdit.cbStatusLahan.Text = dgvLahan.CurrentRow.Cells["colStatusLahan"].Value.ToString();

            popUpEdit.ShowDialog();
        }
        private void btnTambahTanaman_Click(object sender, EventArgs e)
        {
            FormTambahTanaman popUpTambah = new FormTambahTanaman();
            popUpTambah.ShowDialog();
        }
        private void btnEditTanaman_Click(object sender, EventArgs e)
        {
            if (dgvTanaman.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris tanaman terlebih dahulu!", "Peringatan");
                return;
            }

            FormEditTanaman popUpEdit = new FormEditTanaman();
            popUpEdit.txtIdTanaman.Text = dgvTanaman.CurrentRow.Cells["colIdTanaman"].Value.ToString();
            popUpEdit.txtNamaTanaman.Text = dgvTanaman.CurrentRow.Cells["colNamaTanaman"].Value.ToString();
            popUpEdit.txtDurasiPanen.Text = dgvTanaman.CurrentRow.Cells["colDurasiPanen"].Value.ToString();
            popUpEdit.txtHargaTanaman.Text = dgvTanaman.CurrentRow.Cells["colHargaTanaman"].Value.ToString();

            popUpEdit.ShowDialog();
        }
        private void btnTambahJadwal_Click(object sender, EventArgs e)
        {
            FormTambahJadwal popUpTambah = new FormTambahJadwal();
            popUpTambah.ShowDialog();
        }
        private void btnEditJadwal_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris jadwal terlebih dahulu!", "Peringatan");
                return;
            }

            FormEditJadwal popUpEdit = new FormEditJadwal();
            popUpEdit.txtIdJadwal.Text = dgvJadwal.CurrentRow.Cells["colIdJadwal"].Value.ToString();
            popUpEdit.dtpTanggal.Value = Convert.ToDateTime(dgvJadwal.CurrentRow.Cells["colTanggalJadwal"].Value);
            popUpEdit.txtKeterangan.Text = dgvJadwal.CurrentRow.Cells["colKeteranganKegiatan"].Value.ToString();
            popUpEdit.cbTipeJadwal.Text = dgvJadwal.CurrentRow.Cells["colTipeJadwal"].Value.ToString();
            popUpEdit.txtJumlahAnggota.Text = dgvJadwal.CurrentRow.Cells["colJumlahAnggota"].Value.ToString();
            popUpEdit.txtTotalUpah.Text = dgvJadwal.CurrentRow.Cells["colTotalUpah"].Value.ToString();
            popUpEdit.cbStatusGlobal.Text = dgvJadwal.CurrentRow.Cells["colStatusGlobal"].Value.ToString();
            // Mengambil nilai ID dari kolom rahasia DGV untuk dimasukkan ke TextBox Form Edit
            popUpEdit.txtIdLahan.Text = dgvJadwal.CurrentRow.Cells["colIdLahan"].Value?.ToString() ?? "";
            popUpEdit.txtIdPelanggan.Text = dgvJadwal.CurrentRow.Cells["colIdPelanggan"].Value?.ToString() ?? "";

            popUpEdit.ShowDialog();
        }
        private void btnTambahPelanggan_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan popUpTambah = new FormTambahPelanggan();
            popUpTambah.ShowDialog();
        }
        private void btnEditPelanggan_Click(object sender, EventArgs e)
        {
            if (dgvPelanggan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris pelanggan terlebih dahulu!", "Peringatan");
                return;
            }

            FormEditPelanggan popUpEdit = new FormEditPelanggan();
            popUpEdit.txtIdPelanggan.Text = dgvPelanggan.CurrentRow.Cells["colIdPelanggan"].Value.ToString();
            popUpEdit.txtNama.Text = dgvPelanggan.CurrentRow.Cells["colNamaPelanggan"].Value.ToString();
            popUpEdit.txtNoTelp.Text = dgvPelanggan.CurrentRow.Cells["colNoTelpPelanggan"].Value.ToString();
            popUpEdit.txtEmail.Text = dgvPelanggan.CurrentRow.Cells["colEmailPelanggan"].Value.ToString();
            popUpEdit.txtAlamat.Text = dgvPelanggan.CurrentRow.Cells["colAlamatPelanggan"].Value.ToString();

            popUpEdit.ShowDialog();
        }
    }
}