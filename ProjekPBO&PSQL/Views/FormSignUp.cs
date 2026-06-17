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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormSignUp : Form
    {
        OrangController Controller = new OrangController();
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form? formLogin = Application.OpenForms["FormLogin"];

            if (formLogin != null)
            {
                formLogin.Show();
            }
            else
            {
                FormLogin loginBaru = new FormLogin();
                loginBaru.Show();
            }
            this.Close();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Validator.ApakahKosong(txtNama.Text))
            {
                MessageBox.Show("Nama wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtEmail.Text) || !Validator.ApakahEmailValid(txtEmail.Text))
            {
                MessageBox.Show("Email tidak valid atau wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtUsername.Text) || !Validator.ApakahPanjang(8, txtUsername.Text))
            {
                MessageBox.Show("Username wajib diisi dan minimal 8 karakter!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtPassword.Text) || !Validator.ApakahPanjang(8, txtPassword.Text))
            {
                MessageBox.Show("Password wajib diisi dan minimal 8 karakter!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtTelp.Text))
            {
                MessageBox.Show("Nomor Telepon wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelp.Focus();
                return;
            }

            
            if (!rdoFarmer.Checked && !rdoPengantar.Checked)
            {
                MessageBox.Show("Silakan pilih salah satu Role!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string nama = txtNama.Text.Trim();
            string email = txtEmail.Text.Trim(); 
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string noTelp = txtTelp.Text.Trim();
            DateTime tanggalLahir = dtpLahir.Value.Date;

            
            if (Controller.apakahAdaUsername(username) == true)
            {
                MessageBox.Show("Username sudah digunakan! Silakan pilih username lain.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (Controller.apakahAdaEmail(email) == true)
            {
                MessageBox.Show("Email sudah terdaftar!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            int idRole = 0; 

            if (rdoFarmer.Checked)
            {
                idRole = 2;
            }
            else if (rdoPengantar.Checked)
            {
                idRole = 3;
            }

            
            bool apakahSukses = false;

            if (idRole == 2) 
            {
                Farmer farmerBaru = new Farmer(0, nama, noTelp, 0, tanggalLahir, email, "Aktif", idRole, username, password);
                

                apakahSukses = Controller.TambahOrang(farmerBaru);
            }
            else if (idRole == 3) 
            {
                Pengantar pengantarBaru = new Pengantar(0, nama, noTelp, 0, tanggalLahir, email, "Aktif", idRole, username, password);
                

                apakahSukses = Controller.TambahOrang(pengantarBaru);
            }

            if (apakahSukses)
            {
                MessageBox.Show("Pendaftaran Akun Berhasil! Silakan login kembali.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBack_Click(sender, e); 
            }
            else
            {
                MessageBox.Show("Gagal mendaftarkan akun. Terjadi kesalahan internal database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void rdoFarmer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormOwner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
