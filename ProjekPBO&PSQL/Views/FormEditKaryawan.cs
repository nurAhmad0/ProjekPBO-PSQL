using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPBO_PSQL.Controllers;
using System.Security.Cryptography.X509Certificates;

namespace ProjekPBO_PSQL.Views
{

    public partial class FormEditKaryawan : Form
    {
        OrangController controller = new OrangController();
        public int idkaryawan;
        public FormEditKaryawan()
        {
            InitializeComponent();
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (ProjekPBO_PSQL.Controllers.Validator.ApakahKosong(txtNama.Text))
            {
                MessageBox.Show("Nama karyawan wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (ProjekPBO_PSQL.Controllers.Validator.ApakahKosong(txtNoTelp.Text))
            {
                MessageBox.Show("Nomor Telepon wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoTelp.Focus();
                return;
            }

            if (ProjekPBO_PSQL.Controllers.Validator.ApakahKosong(txtEmail.Text))
            {
                MessageBox.Show("Email wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (ProjekPBO_PSQL.Controllers.Validator.ApakahKosong(txtUsername.Text))
            {
                MessageBox.Show("Username baru wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (ProjekPBO_PSQL.Controllers.Validator.ApakahKosong(txtPassword.Text))
            {
                MessageBox.Show("Password wajib diisi!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (cbStatusKerja.SelectedIndex == -1 || string.IsNullOrEmpty(cbStatusKerja.Text))
            {
                MessageBox.Show("Silakan pilih Status Kerja terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatusKerja.Focus();
                return;
            }

            if (txtIdRole.SelectedIndex == -1 || string.IsNullOrEmpty(txtIdRole.Text))
            {
                MessageBox.Show("Silakan pilih Role karyawan terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdRole.Focus();
                return;
            }

            try
            {
                Orang Karyawan = controller.CariBerdasarkanID(idkaryawan)!;

                if (Karyawan == null)
                {
                    MessageBox.Show("Data karyawan lama gagal dimuat atau tidak ditemukan di database!", "Eror Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int idAnggota = Karyawan.getIDOrang();

                string nama = txtNama.Text.Trim();
                string noTelp = txtNoTelp.Text.Trim();
                DateTime tanggalLahir = dtpTanggalLahir.Value.Date;
                string email = txtEmail.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                decimal saldo = 0;
                if (!string.IsNullOrEmpty(txtSaldo.Text))
                {
                    saldo = Convert.ToDecimal(txtSaldo.Text.Trim());
                }

                string statusKerja = cbStatusKerja.Text;
                string namaRole = txtIdRole.Text;
                int idRole = 0;
                Orang karyawanUpdate;
                if (namaRole.ToLower() == "farmer")
                {
                    idRole = 2;
                    karyawanUpdate = new Farmer(
                        idAnggota, nama, noTelp, saldo, tanggalLahir,
                        email, statusKerja, idRole, username, password
                    );
                }
                else if (namaRole.ToLower() == "pengantar")
                {
                    idRole = 3;
                    karyawanUpdate = new Pengantar(
                        idAnggota, nama, noTelp, saldo, tanggalLahir,
                        email, statusKerja, idRole, username, password
                    );
                }
                else
                {
                    karyawanUpdate = new Orang(
                        idAnggota, nama, noTelp, saldo, tanggalLahir,
                        email, statusKerja, namaRole, idRole, username, password
                    );
                }

                bool apakahSukses = controller.UpdateOrang(karyawanUpdate);

                if (apakahSukses)
                {
                    MessageBox.Show("Data karyawan berhasil diperbarui ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan perubahan ke database.", "Eror Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan format data: " + ex.Message, "Kesalahan Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
