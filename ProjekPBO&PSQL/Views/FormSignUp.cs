using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Memanggil kembali Form Login yang tadi disembunyikan (pastikan "FormLogin" sesuai dengan nama class form awal Anda)
            Application.OpenForms["FormLogin"].Show();

            // Menutup Form Sign In ini secara permanen
            this.Close();
        }
    }
}
