using ProjekPBO_PSQL.Models;
using ProjekPBO_PSQL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            int saldo = Convert.ToInt32(txtSaldo.Text);
            string status = cbStatusKerja.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtIdRole.Text;
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
            this.Close();
        }
    }
}
