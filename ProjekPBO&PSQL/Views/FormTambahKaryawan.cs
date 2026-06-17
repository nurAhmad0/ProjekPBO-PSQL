using ProjekPBO_PSQL.Models;
using ProjekPBO_PSQL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPBO_PSQL.Helpers;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormTambahKaryawan : Form
    {
        OrangController orangController = new OrangController();
        public FormTambahKaryawan()
        {
            InitializeComponent();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string namaKaryawan = txtNama.Text;
            string NOtelp = txtNoTelp.Text;
            DateTime TanggalLahir = dtpTanggalLahir.Value;
            string Email = txtEmail.Text;
            string status = cbStatusKerja.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtIdRole.Text;

            if (Validator.ApakahKosong(namaKaryawan))
            {
                MessageBox.Show("Kolom 'Nama Karyawan' wajib diisi, tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (Validator.ApakahKosong(NOtelp))
            {
                MessageBox.Show("Kolom 'Nomor Telepon' wajib diisi, tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }

            if (Validator.ApakahKosong(Email))
            {
                MessageBox.Show("Kolom 'Email' wajib diisi, tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtSaldo.Text))
            {
                MessageBox.Show("Kolom 'Saldo' wajib diisi, tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaldo.Focus();
                return;
            }

            if (Validator.ApakahKosong(status))
            {
                MessageBox.Show("Silakan pilih atau isi 'Status Kerja' terlebih dahulu!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatusKerja.Focus();
                return;
            }

            if (Validator.ApakahKosong(username))
            {
                MessageBox.Show("Kolom 'Username' wajib diisi, tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (Validator.ApakahKosong(password))
            {
                MessageBox.Show("Kolom 'Password' wajib diisi, tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (Validator.ApakahKosong(role))
            {
                MessageBox.Show("Kolom 'Role' (Id Role) wajib diisi, tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdRole.Focus();
                return;
            }
            if (!Validator.ApakahHanyaHurufDanSpasi(namaKaryawan))
            {
                MessageBox.Show("Nama karyawan hanya boleh berisi huruf dan spasi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }
            if (!Validator.ApakahAngka(NOtelp))
            {
                MessageBox.Show("Nomor telepon harus berupa angka seluruhnya!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }
            if (!Validator.ApakahEmailValid(Email))
            {
                MessageBox.Show("Format email yang Anda masukkan tidak valid!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (!Validator.ApakahAngka(txtSaldo.Text))
            {
                MessageBox.Show("Saldo harus berupa angka valid tanpa huruf/simbol!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaldo.Focus();
                return;
            }
            if (!Validator.ApakahHurufdanAngka(username))
            {
                MessageBox.Show("Username hanya boleh berisi gabungan huruf dan angka tanpa spasi!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (!Validator.ApakahPanjang(10, NOtelp, 12))
            {
                MessageBox.Show("Nomor telepon harus terdiri dari 10 ampai 12!", "Duplikasi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }

            if (orangController.apakahAdaNoTelp(NOtelp) == true)
            {
                MessageBox.Show("Nomor telepon sudah terdaftar di sistem!", "Duplikasi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }
            if (orangController.apakahAdaEmail(Email) == true)
            {
                MessageBox.Show("Email sudah digunakan oleh akun lain!", "Duplikasi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (orangController.apakahAdaUsername(username) == true)
            {
                MessageBox.Show("Username sudah diambil! Silakan cari username lain.", "Duplikasi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            int saldo = Convert.ToInt32(txtSaldo.Text);
            int idRole;
            if (txtIdRole.Text == "Farmer")
            {
                idRole = 2;
                Orang orangTambah = new Orang(0, namaKaryawan, NOtelp, saldo, TanggalLahir, Email, status, role, idRole, username, password);
                orangController.TambahOrang(orangTambah);
            }
            else if (txtIdRole.Text =="Pengantar")
            {
                idRole = 3;
                Orang orangTambah = new Orang(0, namaKaryawan, NOtelp, saldo, TanggalLahir, Email, status, role, idRole, username, password);
                orangController.TambahOrang(orangTambah);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
