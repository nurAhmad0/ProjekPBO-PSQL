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
    public partial class FormTambahTanaman : Form
    {
        TanamanController tanamanController = new TanamanController();
        public FormTambahTanaman()
        {
            InitializeComponent();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
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

            bool? cekNama = tanamanController.ApakahAdaNamaTanaman(txtNamaTanaman.Text.Trim());
            if (cekNama == true)
            {
                MessageBox.Show("Nama tanaman sudah ada! Silakan gunakan nama tanaman yang lain.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaTanaman.Focus();
                return;
            }
            else if (cekNama == null)
            {
                MessageBox.Show("Gagal melakukan pengecekan nama tanaman karena masalah koneksi database.", "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Validator.ApakahKosong(txtHargaTanaman.Text))
            {
                MessageBox.Show("Harga tanaman wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHargaTanaman.Focus();
                return;
            }
            if (!Validator.ApakahAngka(txtHargaTanaman.Text))
            {
                MessageBox.Show("Harga tanaman harus berupa angka penuh!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Tanaman tanamanBaru = new Tanaman(0,namaTanaman, hargaTanaman, durasiPanen);
                bool apakahSukses = tanamanController.TambahTanaman(tanamanBaru);

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
