using ProjekPBO_PSQL.Controllers;
using ProjekPBO_PSQL.Helpers;
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
    public partial class FormTambahPelanggan : Form
    {
        PelangganController pelangganController = new PelangganController();
        public FormTambahPelanggan()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (Validator.ApakahKosong(txtNama.Text))
            {
                MessageBox.Show("Nama pelanggan wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }
            if (!Validator.ApakahHanyaHurufDanSpasi(txtNama.Text))
            {
                MessageBox.Show("Nama pelanggan hanya boleh berisi huruf dan spasi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }
            if (Validator.ApakahKosong(txtNoTelp.Text))
            {
                MessageBox.Show("Nomor telepon wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }
            if (!Validator.ApakahAngka(txtNoTelp.Text))
            {
                MessageBox.Show("Nomor telepon harus berupa angka penuh!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }
            if (!Validator.ApakahPanjang(10, txtNoTelp.Text, 13))
            {
                MessageBox.Show("Nomor telepon harus memiliki panjang antara 10 sampai 13 karakter!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }
            bool? cekNoTelp = pelangganController.apakahAdaNoTelp(txtNoTelp.Text.Trim());
            if (cekNoTelp == true)
            {
                MessageBox.Show("Nomor telepon sudah terdaftar! Gunakan nomor lain.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }
            else if (cekNoTelp == null)
            {
                return;
            }
            if (Validator.ApakahKosong(txtEmail.Text))
            {
                MessageBox.Show("Email wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (!Validator.ApakahEmailValid(txtEmail.Text))
            {
                MessageBox.Show("Format email tidak valid! (Contoh: nama@gmail.com)", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            bool? cekEmail = pelangganController.apakahAdaEmail(txtEmail.Text.Trim());
            if (cekEmail == true)
            {
                MessageBox.Show("Email sudah terdaftar! Gunakan email lain.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else if (cekEmail == null)
            {
                return;
            }
            if (Validator.ApakahKosong(txtAlamat.Text))
            {
                MessageBox.Show("Alamat wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlamat.Focus();
                return;
            }
            try
            {
                string nama = txtNama.Text.Trim();
                string noTelp = txtNoTelp.Text.Trim();
                string email = txtEmail.Text.Trim();
                string alamat = txtAlamat.Text.Trim();

                Pelanggan pelanggan = new Pelanggan(0, nama, noTelp, email, alamat);
                bool apakahSukses = pelangganController.TambahPelanggan(pelanggan);
                if (apakahSukses)
                {
                    MessageBox.Show("Data pelanggan berhasil ditambahkan ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtAlamat.Clear();
                    txtEmail.Clear();
                    txtNoTelp.Clear();
                    txtNama.Clear();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data pelanggan ke database.", "Eror Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem saat memproses data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
