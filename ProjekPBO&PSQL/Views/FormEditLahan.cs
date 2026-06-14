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
    public partial class FormEditLahan : Form
    {
        LahanController lahanController = new LahanController();
        public FormEditLahan()
        {
            InitializeComponent();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator.ApakahKosong(txtNamaLahan.Text))
            {
                MessageBox.Show("Nama lahan wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaLahan.Focus();
                return;
            }
            if (!Validator.ApakahHurufAngkaDanSpasi(txtNamaLahan.Text))
            {
                MessageBox.Show("Nama lahan hanya boleh berisi huruf dan spasi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaLahan.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtLuasLahan.Text))
            {
                MessageBox.Show("Luas lahan wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuasLahan.Focus();
                return;
            }
            if (!Decimal.TryParse(txtLuasLahan.Text, out _))
            {
                MessageBox.Show("Luas lahan harus berupa angka!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuasLahan.Focus();
                return;
            }
            if (Convert.ToDecimal(txtLuasLahan.Text) <= 0)
            {
                MessageBox.Show("Luas lahan harus bernilai positif dan lebih dari 0!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuasLahan.Focus();
                return;
            }
            if (cbStatusLahan.SelectedIndex == -1 || string.IsNullOrEmpty(cbStatusLahan.Text))
            {
                MessageBox.Show("Silakan pilih Status Lahan (Aktif/Tidak Aktif) terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatusLahan.Focus();
                return;
            }
            try
            {
                string namaLahan = txtNamaLahan.Text.Trim();
                Decimal luasLahan = Convert.ToDecimal(txtLuasLahan.Text.Trim());
                string statusLahan = cbStatusLahan.Text;
                int idLahan = Convert.ToInt32(txtIdLahan.Text);
                Lahan lahanBaru = new Lahan(idLahan, namaLahan, luasLahan, statusLahan);
                bool apakahSukses = lahanController.updateLahan(lahanBaru);

                if (apakahSukses)
                {
                    MessageBox.Show("Data lahan baru berhasil diUpdate ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data lahan ke database.", "Eror Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem saat memproses data: " + ex.Message, "Kesalahan Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            
        }
    }
}
