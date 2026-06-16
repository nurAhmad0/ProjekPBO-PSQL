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
    public partial class FormEditTanaman : Form
    {
        TanamanController tanamanController = new TanamanController();
        public FormEditTanaman()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator.ApakahKosong(txtNamaTanaman.Text))
            {
                MessageBox.Show("Nama tanaman wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaTanaman.Focus();
                return;
            }
            if (!Validator.ApakahHurufAngkaDanSpasi(txtNamaTanaman.Text))
            {
                MessageBox.Show("Nama tanaman hanya boleh berisi huruf dan spasi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaTanaman.Focus();
                return;
            }


            if (Validator.ApakahKosong(txtHargaTanaman.Text))
            {
                MessageBox.Show("Harga tanaman wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHargaTanaman.Focus();
                return;
            }
            if (!Decimal.TryParse(txtHargaTanaman.Text, out _))
            {
                MessageBox.Show("Harga tanaman harus berupa angka", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHargaTanaman.Focus();
                return;
            }

            if (Convert.ToDecimal(txtHargaTanaman.Text) < 0)
            {
                MessageBox.Show("Harga Tanaman harus positif!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHargaTanaman.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtDurasiPanen.Text))
            {
                MessageBox.Show("Durasi panen wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDurasiPanen.Focus();
                return;
            }
            if (!Validator.ApakahAngka(txtDurasiPanen.Text))
            {
                MessageBox.Show("Durasi panen harus berupa angka bulat (integer)!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDurasiPanen.Focus();
                return;
            }

            if (Convert.ToInt32(txtDurasiPanen.Text) < 0)
            {
                MessageBox.Show("Durasi panen harus positif!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDurasiPanen.Focus();
                return;
            }
            try
            {
                string namaTanaman = txtNamaTanaman.Text.Trim();
                decimal hargaTanaman = Convert.ToDecimal(txtHargaTanaman.Text.Trim());
                int durasiPanen = Convert.ToInt32(txtDurasiPanen.Text.Trim());
                int idTanaman = Convert.ToInt32(txtIdTanaman.Text);
                Tanaman tanamanBaru = new Tanaman(idTanaman, namaTanaman, hargaTanaman, durasiPanen);
                bool apakahSukses = tanamanController.UpdateTanaman(tanamanBaru);

                if (apakahSukses)
                {
                    MessageBox.Show("Data tanaman berhasil ditambahkan ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNamaTanaman.Clear();
                    txtHargaTanaman.Clear();
                    txtDurasiPanen.Clear();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data tanaman ke database.", "Eror Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan format data: " + ex.Message, "Kesalahan Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
