using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormPengantar : Form
    {
        public FormPengantar()
        {
            InitializeComponent();
        }
        private void FormPengantar_Load(object sender, EventArgs e)
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
            FormLaporanPengantar formLaporan = new FormLaporanPengantar();
            formLaporan.ShowDialog();
        }
    }
}
