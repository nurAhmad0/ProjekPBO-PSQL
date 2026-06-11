using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjekPBO_PSQL.Models;
using ProjekPBO_PSQL.Controllers;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormOwner : Form
    {
        OrangController ControllersOrang = new OrangController();
        TanamanController ControllersTanaman = new TanamanController();
        PelangganController ControllersPelanggan = new PelangganController();
        LahanController ControllersLahan = new LahanController();
        RiwayatPenarikanController ControllersPenarikan = new RiwayatPenarikanController();
        JadwalController ControllersJadwal = new JadwalController();

        Orang owner;
        public FormOwner(int id)
        {
            InitializeComponent();
            owner = ControllersOrang.Cari(id)!;

            label7.Text = owner.getSaldo().ToString("N0");
            lblNama.Text = owner.getUsername();
            panelKaryawan.Visible = true;
            panelDetailKaryawan.Visible = false;
            List<Orang> listAsli = ControllersOrang.GetAllKaryawan();
            var dataUntukGrid = listAsli.Select(o => new
            {
                ID = o.getIDOrang(),
                Nama = o.getName(),
                Role = o.getNamaRole()
            }).ToList();
            dgvKaryawan.DataSource = dataUntukGrid;
            dgvKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvLahan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelKaryawan, "Karyawan");
            List<Orang> listAsli = ControllersOrang.GetAllKaryawan();
            var dataUntukGrid = listAsli.Select(o => new
            {
                ID = o.getIDOrang(),
                Nama = o.getName(),
                Role = o.getNamaRole()
            }).ToList();
            dgvKaryawan.DataSource = dataUntukGrid;
            dgvKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLahan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelLahan, "Lahan");
            List<Lahan> listAsli = ControllersLahan.GetAllLahan();
            var dataUntukGrid = listAsli.Select(o => new
            {
                ID = o.getIdLahan(),
                Nama = o.getNamaLahan(),
                Harga = o.getLuasLahan(),
                Estimasi_Kadaluarsa = o.getStatusLahan()
            }).ToList();
            dgvLahan.DataSource = dataUntukGrid;
            dgvLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTanaman_Click(object sender, EventArgs e)
        {
            PindahPanel(panelTanaman, "Tanaman");
            List<Tanaman> listAsli = ControllersTanaman.GetAllTanaman();
            var dataUntukGrid = listAsli.Select(o => new
            {
                ID = o.getIdTanaman(),
                Nama = o.getNamaTanaman(),
                Harga = o.getHargaTanaman(),
                Estimasi_Kadaluarsa = o.getEstimasiKadaluarsa()
            }).ToList();
            dgvTanaman.DataSource = dataUntukGrid;
            dgvTanaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            PindahPanel(panelJadwal, "Jadwal");
            try
            {
                DataTable dtJadwal = ControllersJadwal.GetAllJadwalOwnerHariIni();
                dgvJadwal.DataSource = dtJadwal;
                dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvJadwal.Columns.Contains("id_jadwal"))
                {
                    dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                    dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                    dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan";
                    dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                    dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Jumlah Pekerja";
                    dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                    dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
                    dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat jadwal hari ini: " + ex.Message, "Eror Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelPelanggan, "Pelanggan");
            List<Pelanggan> listAsli = ControllersPelanggan.GetAllPelanggan();
            var dataUntukGrid = listAsli.Select(o => new
            {
                ID = o.getIdPelanggan(),
                Nama = o.getNamePelanggan(),
                Email = o.getEmail(),
                Nomor_Telp = o.getNO_TELP(),
                Alamat = o.getDetailAlamat()
            }).ToList();
            dgvPelanggan.DataSource = dataUntukGrid;
            dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelLainnya, "Lainnya");
        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            FormTambahKaryawan popUpTambah = new FormTambahKaryawan();
            popUpTambah.ShowDialog();
        }
        private void btnEditKaryawan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelDetailKaryawan, "DetailKaryawan");
            if (dgvKaryawan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris karyawan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTerpilih = Convert.ToInt32(dgvKaryawan.CurrentRow.Cells["ID"].Value);
                Orang karyawanTerpilih = ControllersOrang.Cari(idTerpilih)!;
                if (karyawanTerpilih == null)
                {
                    MessageBox.Show("Data karyawan tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lbID.Text = karyawanTerpilih.getIDOrang().ToString();
                lbNama.Text = karyawanTerpilih.getName();
                lbNOTELP.Text = karyawanTerpilih.getNO_TELP();
                lbTanggalLahir.Text = karyawanTerpilih.getTanggalLahir().ToString("dd MMMM yyyy");
                lbEmail.Text = karyawanTerpilih.getEmail();
                lbStatusKerja.Text = karyawanTerpilih.getStatus();
                lbSaldo.Text = karyawanTerpilih.getSaldo().ToString("N0");
                lbUsername.Text = karyawanTerpilih.getUsername();
                lbPassword.Text = karyawanTerpilih.getPassword();
                lbRole.Text = karyawanTerpilih.getNamaRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTambahLahan_Click(object sender, EventArgs e)
        {
            FormTambahLahan popUpTambah = new FormTambahLahan();
            this.Hide();
            DialogResult hasil = popUpTambah.ShowDialog();
            this.Show();
            if (hasil == DialogResult.OK)
            {
                List<Lahan> listAsli = ControllersLahan.GetAllLahan();
                var dataUntukGrid = listAsli.Select(o => new
                {
                    ID = o.getIdLahan(),
                    Nama = o.getNamaLahan(),
                    Harga = o.getLuasLahan(),
                    Estimasi_Kadaluarsa = o.getStatusLahan()
                }).ToList();
                dgvLahan.DataSource = dataUntukGrid;
                dgvLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void btnEditLahan_Click(object sender, EventArgs e)
        {
            if (dgvLahan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris lahan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTerpilih = Convert.ToInt32(dgvLahan.CurrentRow.Cells["ID"].Value);
                Lahan lahanTerpilih = ControllersLahan.Cari(idTerpilih)!;
                if (lahanTerpilih == null)
                {
                    MessageBox.Show("Data lahan tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FormEditLahan popUpEdit = new FormEditLahan();
                popUpEdit.txtIdLahan.Text = lahanTerpilih.getIdLahan().ToString();
                popUpEdit.txtNamaLahan.Text = lahanTerpilih.getNamaLahan();
                popUpEdit.txtLuasLahan.Text = lahanTerpilih.getLuasLahan().ToString();
                popUpEdit.cbStatusLahan.Text = lahanTerpilih.getStatusLahan();
                this.Hide();
                DialogResult hasil = popUpEdit.ShowDialog();
                this.Show();
                if (hasil == DialogResult.OK)
                {
                    List<Lahan> listAsli = ControllersLahan.GetAllLahan();
                    var dataUntukGrid = listAsli.Select(o => new
                    {
                        ID = o.getIdLahan(),
                        Nama = o.getNamaLahan(),
                        Harga = o.getLuasLahan(),
                        Estimasi_Kadaluarsa = o.getStatusLahan()
                    }).ToList();
                    dgvLahan.DataSource = dataUntukGrid;
                    dgvLahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTambahTanaman_Click(object sender, EventArgs e)
        {
            FormTambahTanaman popUpTambah = new FormTambahTanaman();
            this.Hide();
            DialogResult hasil = popUpTambah.ShowDialog();
            this.Show();
            if (hasil == DialogResult.OK)
            {
                List<Tanaman> listAsli = ControllersTanaman.GetAllTanaman();
                var dataUntukGrid = listAsli.Select(o => new
                {
                    ID = o.getIdTanaman(),
                    Nama = o.getNamaTanaman(),
                    Harga = o.getHargaTanaman(),
                    Estimasi_Kadaluarsa = o.getEstimasiKadaluarsa()
                }).ToList();
                dgvTanaman.DataSource = dataUntukGrid;
                dgvTanaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void btnEditTanaman_Click(object sender, EventArgs e)
        {
            if (dgvTanaman.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris tanaman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTerpilih = Convert.ToInt32(dgvTanaman.CurrentRow.Cells["ID"].Value);
                Tanaman tanamanTerpilih = ControllersTanaman.Cari(idTerpilih)!;
                if (tanamanTerpilih == null)
                {
                    MessageBox.Show("Data tanaman tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FormEditTanaman popUpEdit = new FormEditTanaman();
                popUpEdit.txtIdTanaman.Text = tanamanTerpilih.getIdTanaman().ToString();
                popUpEdit.txtNamaTanaman.Text = tanamanTerpilih.getNamaTanaman();
                popUpEdit.txtDurasiPanen.Text = tanamanTerpilih.getEstimasiKadaluarsa().ToString();
                popUpEdit.txtHargaTanaman.Text = tanamanTerpilih.getHargaTanaman().ToString();

                this.Hide();
                DialogResult hasil = popUpEdit.ShowDialog();
                this.Show();
                if (hasil == DialogResult.OK)
                {
                    List<Tanaman> listAsli = ControllersTanaman.GetAllTanaman();
                    var dataUntukGrid = listAsli.Select(o => new
                    {
                        ID = o.getIdTanaman(),
                        Nama = o.getNamaTanaman(),
                        Harga = o.getHargaTanaman(),
                        Estimasi_Kadaluarsa = o.getEstimasiKadaluarsa()
                    }).ToList();
                    dgvTanaman.DataSource = dataUntukGrid;
                    dgvTanaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnTambahJadwal_Click(object sender, EventArgs e)
        {
            //FormTambahJadwal popUpTambah = new FormTambahJadwal();
            //popUpTambah.ShowDialog();
            PindahPanel(panelPilihanJadwal, "PilihanJadwal");
        }
        private void btnEditJadwal_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris jadwal terlebih dahulu!", "Peringatan");
                return;
            }

            FormEditJadwal popUpEdit = new FormEditJadwal();
            popUpEdit.txtIdJadwal.Text = dgvJadwal.CurrentRow.Cells["colIdJadwal"].Value.ToString();
            popUpEdit.dtpTanggal.Value = Convert.ToDateTime(dgvJadwal.CurrentRow.Cells["colTanggalJadwal"].Value);
            popUpEdit.txtKeterangan.Text = dgvJadwal.CurrentRow.Cells["colKeteranganKegiatan"].Value.ToString();
            popUpEdit.cbTipeJadwal.Text = dgvJadwal.CurrentRow.Cells["colTipeJadwal"].Value.ToString();
            popUpEdit.txtJumlahAnggota.Text = dgvJadwal.CurrentRow.Cells["colJumlahAnggota"].Value.ToString();
            popUpEdit.txtTotalUpah.Text = dgvJadwal.CurrentRow.Cells["colTotalUpah"].Value.ToString();
            popUpEdit.cbStatusGlobal.Text = dgvJadwal.CurrentRow.Cells["colStatusGlobal"].Value.ToString();
            // Mengambil nilai ID dari kolom rahasia DGV untuk dimasukkan ke TextBox Form Edit
            popUpEdit.txtIdLahan.Text = dgvJadwal.CurrentRow.Cells["colIdLahan"].Value?.ToString() ?? "";
            popUpEdit.txtIdPelanggan.Text = dgvJadwal.CurrentRow.Cells["colIdPelanggan"].Value?.ToString() ?? "";

            popUpEdit.ShowDialog();
        }
        private void btnTambahPelanggan_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan popUpTambah = new FormTambahPelanggan();
            this.Hide();
            DialogResult Hasil = popUpTambah.ShowDialog();
            this.Show();
            if (Hasil == DialogResult.OK)
            {
                List<Pelanggan> listAsli = ControllersPelanggan.GetAllPelanggan();
                var dataUntukGrid = listAsli.Select(o => new
                {
                    ID = o.getIdPelanggan(),
                    Nama = o.getNamePelanggan(),
                    Email = o.getEmail(),
                    Nomor_Telp = o.getNO_TELP(),
                    Alamat = o.getDetailAlamat()
                }).ToList();
                dgvPelanggan.DataSource = dataUntukGrid;
                dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void btnEditPelanggan_Click(object sender, EventArgs e)
        {
            if (dgvPelanggan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris tanaman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTerpilih = Convert.ToInt32(dgvPelanggan.CurrentRow.Cells["ID"].Value);
                Pelanggan PelangganTerpilih = ControllersPelanggan.Cari(idTerpilih)!;
                if (PelangganTerpilih == null)
                {
                    MessageBox.Show("Data tanaman tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FormEditPelanggan popUpEdit = new FormEditPelanggan();
                popUpEdit.txtIdPelanggan.Text = PelangganTerpilih.getIdPelanggan().ToString();
                popUpEdit.txtNama.Text = PelangganTerpilih.getNamePelanggan();
                popUpEdit.txtNoTelp.Text = PelangganTerpilih.getNO_TELP();
                popUpEdit.txtEmail.Text = PelangganTerpilih.getEmail();
                popUpEdit.txtAlamat.Text = PelangganTerpilih.getDetailAlamat();

                this.Hide();
                DialogResult Hasil = popUpEdit.ShowDialog();
                this.Show();
                if (Hasil == DialogResult.OK)
                {
                    List<Pelanggan> listAsli = ControllersPelanggan.GetAllPelanggan();
                    var dataUntukGrid = listAsli.Select(o => new
                    {
                        ID = o.getIdPelanggan(),
                        Nama = o.getNamePelanggan(),
                        Email = o.getEmail(),
                        Nomor_Telp = o.getNO_TELP(),
                        Alamat = o.getDetailAlamat()
                    }).ToList();
                    dgvPelanggan.DataSource = dataUntukGrid;
                    dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvLaporan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            PindahPanel(panelKaryawan, "Karyawan");
            List<Orang> listAsli = ControllersOrang.GetAllKaryawan();
            var dataUntukGrid = listAsli.Select(o => new
            {
                ID = o.getIDOrang(),
                Nama = o.getName(),
                Role = o.getNamaRole()
            }).ToList();
            dgvKaryawan.DataSource = dataUntukGrid;
            dgvKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            //DialogResult konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menonaktifkan data ini?","Konfirmasi Hapus",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            //if (konfirmasi == DialogResult.Yes)
            //{
            //    try
            //    {
            //        // --- TARUH LOGIKA PANGGIL CONTROLLER HAPUS DI SINI ---
            //        // Contoh: 
            //        // bool apakahSukses = ControllersOrang.HapusKaryawan(idTerpilih);

            //        // if (apakahSukses) {
            //        //     MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //     // Refresh grid kamu di sini
            //        // }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Gagal menghapus data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int idTerpilih = Convert.ToInt32(lbID.Text);
                Orang karyawanTerpilih = ControllersOrang.Cari(idTerpilih)!;
                if (karyawanTerpilih == null)
                {
                    MessageBox.Show("Data karyawan tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FormEditKaryawan popUpEdit = new FormEditKaryawan();
                popUpEdit.txtIdAnggota.Text = karyawanTerpilih.getIDOrang().ToString();
                popUpEdit.txtNama.Text = karyawanTerpilih.getName();
                popUpEdit.txtNoTelp.Text = karyawanTerpilih.getNO_TELP();
                popUpEdit.dtpTanggalLahir.Value = karyawanTerpilih.getTanggalLahir();
                popUpEdit.txtEmail.Text = karyawanTerpilih.getEmail();
                popUpEdit.cbStatusKerja.Text = karyawanTerpilih.getStatus();
                popUpEdit.txtSaldo.Text = karyawanTerpilih.getSaldo().ToString();
                popUpEdit.txtUsername.Text = karyawanTerpilih.getUsername();
                popUpEdit.txtPassword.Text = karyawanTerpilih.getPassword();
                this.Hide();
                DialogResult hasil = popUpEdit.ShowDialog();
                this.Show();
                if (hasil == DialogResult.OK)
                {
                    Orang karyawanTerbaru = ControllersOrang.Cari(idTerpilih)!;

                    if (karyawanTerbaru != null)
                    {
                        lbID.Text = karyawanTerbaru.getIDOrang().ToString();
                        lbNama.Text = karyawanTerbaru.getName();
                        lbNOTELP.Text = karyawanTerbaru.getNO_TELP();
                        lbTanggalLahir.Text = karyawanTerbaru.getTanggalLahir().ToString("dd MMMM yyyy");
                        lbEmail.Text = karyawanTerbaru.getEmail();
                        lbStatusKerja.Text = karyawanTerbaru.getStatus();
                        lbSaldo.Text = karyawanTerbaru.getSaldo().ToString("N0");
                        lbUsername.Text = karyawanTerbaru.getUsername();
                        lbPassword.Text = karyawanTerbaru.getPassword();
                        lbRole.Text = karyawanTerbaru.getNamaRole();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ControllersTanaman.Get10TanamanPalingDIbeli();
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvTanaman.DataSource = dt;
                    dgvTanaman.Columns["id_tanaman"]!.HeaderText = "ID Tanaman";
                    dgvTanaman.Columns["nama_tanaman"]!.HeaderText = "Nama Tanaman";
                    dgvTanaman.Columns["harga"]!.HeaderText = "Harga Jual (Rp)";
                    dgvTanaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Tidak ada data tanaman yang ditemukan atau belum ada transaksi.", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvTanaman.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data ke tabel: " + ex.Message, "Kesalahan Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTanmanaBelumLaku_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ControllersTanaman.GetTanamanBelumlaku();
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvTanaman.DataSource = dt;
                    dgvTanaman.Columns["id_tanaman"]!.HeaderText = "ID Tanaman";
                    dgvTanaman.Columns["nama_tanaman"]!.HeaderText = "Nama Tanaman";
                    dgvTanaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Tidak ada data tanaman yang ditemukan atau belum ada transaksi.", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvTanaman.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data ke tabel: " + ex.Message, "Kesalahan Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLaporan_Click(object sender, EventArgs e)
        {

        }

        private void btPenarikan_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPenarikan = ControllersPenarikan.TampilSemuaPenarikan();
                dgvLainnya.DataSource = dtPenarikan;
                dgvLainnya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvLainnya.Columns.Contains("id_riwayat_penarikan"))
                {
                    dgvLainnya.Columns["id_riwayat_penarikan"]!.HeaderText = "ID Penarikan";
                    dgvLainnya.Columns["tanggal_penarikan"]!.HeaderText = "Tanggal";
                    dgvLainnya.Columns["metode_penarikan"]!.HeaderText = "Metode";
                    dgvLainnya.Columns["nominal"]!.HeaderText = "Nominal (Rp)";
                    dgvLainnya.Columns["status_pencairan"]!.HeaderText = "Status";
                    dgvLainnya.Columns["nama_anggota"]!.HeaderText = "Nama Anggota";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyegarkan tabel: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            PindahPanel(panelJadwal, "Jadwal");
            try
            {
                DataTable dtJadwal = ControllersJadwal.GetAllJadwalOwnerHariIni();
                dgvJadwal.DataSource = dtJadwal;
                dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvJadwal.Columns.Contains("id_jadwal"))
                {
                    dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                    dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                    dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan";
                    dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                    dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Jumlah Pekerja";
                    dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                    dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
                    dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat jadwal hari ini: " + ex.Message, "Eror Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPengantar_Click(object sender, EventArgs e)
        {
            PindahPanel(panelPilihanJadwalFarmer, "pilihanJadwalFarmer");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PindahPanel(panelPilihanJadwal, "PilihanJadwal");
        }

        private void btTanam_Click(object sender, EventArgs e)
        {
            FormTambahJadwal TambahJadwal = new FormTambahJadwal(("Farmer", "Menanam"));
            this.Hide();
            DialogResult hasil = TambahJadwal.ShowDialog();
            this.Show();
            if (hasil == DialogResult.OK)
            {
                PindahPanel(panelJadwal, "Jadwal");
                try
                {
                    DataTable dtJadwal = ControllersJadwal.GetAllJadwalOwnerHariIni();
                    dgvJadwal.DataSource = dtJadwal;
                    dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (dgvJadwal.Columns.Contains("id_jadwal"))
                    {
                        dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                        dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                        dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan";
                        dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                        dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Jumlah Pekerja";
                        dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                        dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
                        dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat jadwal hari ini: " + ex.Message, "Eror Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btPanen_Click(object sender, EventArgs e)
        {
            FormTambahJadwal TambahJadwal = new FormTambahJadwal(("Farmer", "Panen"));
            this.Hide();
            DialogResult hasil = TambahJadwal.ShowDialog();
            this.Show();
            if (hasil == DialogResult.OK)
            {
                PindahPanel(panelJadwal, "Jadwal");
                try
                {
                    DataTable dtJadwal = ControllersJadwal.GetAllJadwalOwnerHariIni();
                    dgvJadwal.DataSource = dtJadwal;
                    dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (dgvJadwal.Columns.Contains("id_jadwal"))
                    {
                        dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                        dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                        dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan";
                        dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                        dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Jumlah Pekerja";
                        dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                        dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
                        dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat jadwal hari ini: " + ex.Message, "Eror Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btJadwalFarmerLainnya_Click(object sender, EventArgs e)
        {
            FormTambahJadwal TambahJadwal = new FormTambahJadwal(("Farmer", "Lainnya"));
            this.Hide();
            DialogResult hasil = TambahJadwal.ShowDialog();
            this.Show();
            if (hasil == DialogResult.OK)
            {
                PindahPanel(panelJadwal, "Jadwal");
                try
                {
                    DataTable dtJadwal = ControllersJadwal.GetAllJadwalOwnerHariIni();
                    dgvJadwal.DataSource = dtJadwal;
                    dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    if (dgvJadwal.Columns.Contains("id_jadwal"))
                    {
                        dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                        dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                        dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan";
                        dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                        dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Jumlah Pekerja";
                        dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                        dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
                        dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat jadwal hari ini: " + ex.Message, "Eror Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}