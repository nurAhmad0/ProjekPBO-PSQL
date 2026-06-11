using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormTambahJadwal : Form
    {
        (string tipeJadwal, string template) infoJadwal;
        public FormTambahJadwal((string tipeJadwal, string template) infoJadwal)
        {
            InitializeComponent();
            this.infoJadwal = infoJadwal;
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
    }
}