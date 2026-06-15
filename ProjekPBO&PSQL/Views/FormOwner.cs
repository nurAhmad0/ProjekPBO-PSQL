using ProjekPBO_PSQL.Controllers;
using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        LaporanController ControllersLaporan = new LaporanController();

        private string menuAktif = "";
        private Orang owner;
        public FormOwner(int id)
        {
            InitializeComponent();
            owner = ControllersOrang.Cari(id)!;

            label7.Text = owner.getSaldo().ToString("N0");
            lblNama.Text = owner.getUsername();
            PindahPanel(panelKaryawan, "karyawan");
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
                DataTable dtJadwal = ControllersJadwal.GetAllJadwalOwner();
                dgvJadwal.DataSource = dtJadwal;
                dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvJadwal.Columns.Contains("id_jadwal"))
                {
                    dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                    dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                    dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan";
                    dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jadwal";
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
            menuAktif = "Laporan";
            List<Laporan> listAsli = ControllersLaporan.getAllLaporan();
            var dataUntukGrid = listAsli.Select(o => new
            {
                tanggal_jadwal = o.getTanggalJadwal(),
                Waktu_lapor = o.getWaktuLapor(),
                id_laporan = o.getIdlaporan(),
                isi_laporan = o.getIsiLaporan(),
                id_anggota = o.getIdAnggota(),
                nama_anggota = o.getNamaAnggota(),
                id_jadwal = o.getidJadwal(),
                keterangan_kegiatan = o.getKeteranganKegiatan()
            }).ToList();
            dgvLainnya.DataSource = dataUntukGrid;
            dgvLainnya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            FormTambahKaryawan popUpTambah = new FormTambahKaryawan();
            this.Close();
            DialogResult hasil = popUpTambah.ShowDialog();
            if (hasil == DialogResult.OK)
            {
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
            //PindahPanel(panelJadwal, "Jadwal");
            //try
            //{
            //    DataTable dtJadwal = ControllersJadwal.GetAllJadwalOwnerHariIni();
            //    dgvJadwal.DataSource = dtJadwal;
            //    dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //    if (dgvJadwal.Columns.Contains("id_jadwal"))
            //    {
            //        dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
            //        dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
            //        dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan";
            //        dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
            //        dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Jumlah Pekerja";
            //        dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
            //        dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
            //        dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Gagal memuat jadwal hari ini: " + ex.Message, "Eror Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (dgvJadwal.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris jadwal terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTerpilih = Convert.ToInt32(dgvJadwal.CurrentRow.Cells["id_jadwal"].Value);
                string tipeJadwal = Convert.ToString(dgvJadwal.CurrentRow.Cells["text_tipe_jadwal"].Value)!;
                if (tipeJadwal == "Farmer")
                {
                    JadwalFarmer JadwalTerpilih = ControllersJadwal.GetAllJadwalFarmer(idTerpilih)!;
                    if (JadwalTerpilih == null)
                    {
                        MessageBox.Show("Data jadwal farmer tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    txtTanamanJadwalFarmer.ReadOnly = true;
                    txtTotalUpah.ReadOnly = true;
                    txtStatusJadwalFarmer.ReadOnly = true;
                    txtKeteranganJadwalFarmer.ReadOnly = true;
                    txtBanyakAnggotaJadwalFarmer.ReadOnly = true;
                    txtJumlahDItanamJadwalFarmer.ReadOnly = true;
                    txtNamaLahanJadwalFarmer.ReadOnly = true;
                    txtIdLahanJadwalFarmer.ReadOnly = true;

                    lbIdJadwalFarmer.Text = Convert.ToString(JadwalTerpilih.getIdJadwal());
                    txtTanamanJadwalFarmer.Text = JadwalTerpilih.getNamaTanaman();
                    txtTotalUpah.Text = Convert.ToString(JadwalTerpilih.getTotalUpah());
                    txtStatusJadwalFarmer.Text = JadwalTerpilih.getStatus();
                    txtKeteranganJadwalFarmer.Text = JadwalTerpilih.getKeteranganKegiatan();
                    txtBanyakAnggotaJadwalFarmer.Text = Convert.ToString(JadwalTerpilih.getBanyakAnggota());
                    lbTanggalJadwalFarmer.Text = Convert.ToString(JadwalTerpilih.getTanggal());
                    txtJumlahDItanamJadwalFarmer.Text = Convert.ToString(JadwalTerpilih.getJumlahDitanam());
                    txtNamaLahanJadwalFarmer.Text = JadwalTerpilih.getNamaLahan();
                    txtIdLahanJadwalFarmer.Text = Convert.ToString(JadwalTerpilih.getIDLahan());
                    List<DetailAnggotaJadwal> listDetailAnggota = JadwalTerpilih.getDaftarAnggota();

                    dataGAnggotaJadwalFarmer.Rows.Clear();
                    dataGAnggotaJadwalFarmer.Columns.Clear();

                    dataGAnggotaJadwalFarmer.Columns.Add("colIdAnggota", "ID Anggota");
                    dataGAnggotaJadwalFarmer.Columns.Add("colNamaAnggota", "Nama Anggota");
                    foreach (DetailAnggotaJadwal anggota in listDetailAnggota)
                    {
                        int rowIndex = dataGAnggotaJadwalFarmer.Rows.Add(anggota.getIdAnggota(), anggota.getNamaAnggota());

                        if (dataGAnggotaJadwalFarmer.Columns.Contains("colIdAnggota"))
                        {
                            dataGAnggotaJadwalFarmer.Columns["colIdAnggota"]!.HeaderText = "ID Anggota";
                            dataGAnggotaJadwalFarmer.Columns["colNamaAnggota"]!.HeaderText = "Nama Anggota";
                        }
                    }
                    PindahPanel(panelDetailJadwalFarmer, "DetailJadwalFarmer");
                }
                else if (tipeJadwal == "Pengantar")
                {
                    JadwalPengantaran JadwalTerpilih = ControllersJadwal.GetAllJadwalPengantaran(idTerpilih)!;
                    if (JadwalTerpilih == null)
                    {
                        MessageBox.Show("Data jadwal pangantaran tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    txtIDJadwalPengantar.ReadOnly = true;
                    txtStatusJadwalPengantar.ReadOnly = true;
                    txtNamaAnggotaPengantar.ReadOnly = true;
                    txtTotalUpahPengantar.ReadOnly = true;
                    txtNoTelpJadwalPengantar.ReadOnly = true;
                    txtKeteranganJadwalPengantar.ReadOnly = true;
                    txtIdPelangganPengantar.ReadOnly = true;
                    txtNamaPelanggan.ReadOnly = true;
                    txtTanggalOrderPengantar.ReadOnly = true;
                    txtDetailAlamatPengantar.ReadOnly = true;

                    lbTanggalJadwalPengantaran.Text = Convert.ToString(JadwalTerpilih.getTanggal());
                    txtIDJadwalPengantar.Text = Convert.ToString(JadwalTerpilih.getIdJadwal());
                    txtStatusJadwalPengantar.Text = JadwalTerpilih.getStatus();
                    txtNamaAnggotaPengantar.Text = JadwalTerpilih.getDaftarAnggota()[0].getNamaAnggota();
                    txtTotalUpahPengantar.Text = Convert.ToString(JadwalTerpilih.getTotalUpah());
                    txtNoTelpJadwalPengantar.Text = JadwalTerpilih.getNO_TELP();
                    txtKeteranganJadwalPengantar.Text = JadwalTerpilih.getKeteranganKegiatan();
                    txtIdPelangganPengantar.Text = Convert.ToString(JadwalTerpilih.getIDPelanggan());
                    txtNamaPelanggan.Text = JadwalTerpilih.getNamaPelanggan();
                    txtTanggalOrderPengantar.Text = Convert.ToString(JadwalTerpilih.getOrderData().getTanggalOrder());
                    txtDetailAlamatPengantar.Text = JadwalTerpilih.getDetailAlamat();

                    dataGKeranjangBelanja.Rows.Clear();
                    dataGKeranjangBelanja.Columns.Clear();
                    Order orderTerpilih = JadwalTerpilih.getOrderData();

                    dataGKeranjangBelanja.Columns.Add("colNamaTanaman", "Nama Tanaman");
                    dataGKeranjangBelanja.Columns.Add("colHarga", "Harga (Rp)");
                    dataGKeranjangBelanja.Columns.Add("colJumlah", "Jumlah Keluar");

                    if (dataGKeranjangBelanja.Columns.Contains("colHarga"))
                    {
                        dataGKeranjangBelanja.Columns["colHarga"]!.DefaultCellStyle.Format = "N0";
                    }

                    List<OrderDetails> keranjangBelanja = orderTerpilih.getlistOrderdetails();

                    foreach (OrderDetails orderD in keranjangBelanja)
                    {
                        dataGKeranjangBelanja.Rows.Add(
                            orderD.getNamaTanaman(),
                            orderD.getHarga(),
                            orderD.getJumlahOrder()
                        );
                    }

                    PindahPanel(panelDetailJadwalPengantar, "DetailJadwalPengantar");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            menuAktif = "Laporan";
            List<Laporan> listAsli = ControllersLaporan.getAllLaporan();
            var dataUntukGrid = listAsli.Select(o => new
            {
                tanggal_jadwal = o.getTanggalJadwal(),
                Waktu_lapor = o.getWaktuLapor(),
                id_laporan = o.getIdlaporan(),
                isi_laporan = o.getIsiLaporan(),
                id_anggota = o.getIdAnggota(),
                nama_anggota = o.getNamaAnggota(),
                id_jadwal = o.getidJadwal(),
                keterangan_kegiatan = o.getKeteranganKegiatan()
            }).ToList();
            dgvLainnya.DataSource = dataUntukGrid;
            dgvLainnya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btPenarikan_Click(object sender, EventArgs e)
        {
            menuAktif = "Penarikan";
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
                    dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jadwal";
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
            FormTambahJadwalFarmer TambahJadwal = new FormTambahJadwalFarmer(("Farmer", "Menanam"));
            TambahJadwal.txtKeterangan.Text = "Tanam Tanaman dilahan";
            TambahJadwal.txtKeterangan.ReadOnly = true;
            TambahJadwal.txtTipeJadwal.Text = "Farmer";
            TambahJadwal.txtTipeJadwal.ReadOnly = true;
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
            FormTambahJadwalFarmer TambahJadwal = new FormTambahJadwalFarmer(("Farmer", "Panen"));
            TambahJadwal.txtKeterangan.Text = "Memanen Tanaman yang ada di lahan";
            TambahJadwal.txtTipeJadwal.Text = "Farmer";
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
            FormTambahJadwalFarmer TambahJadwal = new FormTambahJadwalFarmer(("Farmer", "Lainnya"));
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

        private void btFarmer_Click(object sender, EventArgs e)
        {
            FormTambahJadwalPengantaran TambahJadwal = new FormTambahJadwalPengantaran();
            TambahJadwal.txtTipeJadwal.Text = "Pengantar";
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

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void dataGAnggotaJadwalFarmer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PindahPanel(panelJadwal, "Jadwal");
        }

        private void btEditJadwalPengantar_Click(object sender, EventArgs e)
        {
            btSimpanEditPengantar.Visible = true;
            btSimpanEditPengantar.Enabled = true;
            txtTotalUpahPengantar.ReadOnly = false;
            txtKeteranganJadwalPengantar.ReadOnly = false;

        }

        private void btSimpanEditPengantar_Click(object sender, EventArgs e)
        {
            int idJadwal = Convert.ToInt32(txtIDJadwalPengantar.Text);

            if (Validator.ApakahKosong(txtKeteranganJadwalPengantar.Text))
            {
                MessageBox.Show("Keterangan kegiatan pengantaran tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Validator.ApakahKosong(txtTotalUpahPengantar.Text))
            {
                MessageBox.Show("total upah tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validator.ApakahAngka(txtTotalUpahPengantar.Text))
            {
                MessageBox.Show("Total upah harus angka!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalUpahPengantar = Convert.ToDecimal(txtTotalUpahPengantar.Text);

            if (totalUpahPengantar < 0)
            {
                MessageBox.Show("Total upah tidak boleh negatif!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            JadwalPengantaran JadwalUpdate = new JadwalPengantaran(idJadwal, Convert.ToDateTime(lbTanggalJadwalPengantaran.Text), txtKeteranganJadwalPengantar.Text, 1, txtStatusJadwalPengantar.Text, "", "", "", Convert.ToInt32(txtIdPelangganPengantar.Text), totalUpahPengantar, null!);

            bool hasil = ControllersJadwal.UpdateJadwal(JadwalUpdate);

            if (hasil)
            {
                MessageBox.Show("Jadwal pengantaran berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSimpanEditPengantar.Visible = false;
                btSimpanEditPengantar.Enabled = false;
                txtTotalUpahPengantar.ReadOnly = true;
                txtKeteranganJadwalPengantar.ReadOnly = true;
                PindahPanel(panelJadwal, "Jadwal");
            }
            else
            {
                MessageBox.Show("Gagal menyimpan perubahan ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btJadwalPengantarHapus_Click(object sender, EventArgs e)
        {
            int idJadwal = Convert.ToInt32(txtIDJadwalPengantar.Text);
            bool hasil = ControllersJadwal.DelateJadwal(idJadwal);

            if (hasil)
            {
                MessageBox.Show("Jadwal pengantaran berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Gagal menyimpan perubahan ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKembaliJadwalFarmer_Click(object sender, EventArgs e)
        {
            PindahPanel(panelJadwal, "Jadwal");
        }

        private void btHapusJadwalFarmer_Click(object sender, EventArgs e)
        {
            int idJadwal = Convert.ToInt32(lbIdJadwalFarmer.Text);
            bool hasil = ControllersJadwal.DelateJadwal(idJadwal);

            if (hasil)
            {
                MessageBox.Show("Jadwal farmer berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Gagal menyimpan perubahan ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditJadwalFarmer_Click(object sender, EventArgs e)
        {
            btSimpanEditFarmer.Visible = true;
            btSimpanEditFarmer.Enabled = true;
            txtTotalUpah.ReadOnly = false;
            txtKeteranganJadwalFarmer.ReadOnly = false;
        }

        private void btSimpanEditFarmer_Click(object sender, EventArgs e)
        {
            int idJadwal = Convert.ToInt32(txtIDJadwalPengantar.Text);

            if (Validator.ApakahKosong(txtKeteranganJadwalPengantar.Text))
            {
                MessageBox.Show("Keterangan kegiatan farmer tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Validator.ApakahKosong(txtTotalUpah.Text))
            {
                MessageBox.Show("total upah tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validator.ApakahAngka(txtTotalUpah.Text))
            {
                MessageBox.Show("Total upah harus angka!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalUpahFarmer = Convert.ToDecimal(txtTotalUpah.Text);

            if (totalUpahFarmer < 0)
            {
                MessageBox.Show("Total upah tidak boleh negatif!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            JadwalFarmer JadwalUpdate = new JadwalFarmer(idJadwal, Convert.ToDateTime(lbTanggalJadwalFarmer.Text), txtKeteranganJadwalFarmer.Text, Convert.ToInt32(txtBanyakAnggotaJadwalFarmer.Text), txtStatusJadwalFarmer.Text, "", "", DateTime.Now, Convert.ToInt32(txtJumlahDItanamJadwalFarmer.Text), Convert.ToInt32(txtIdLahanJadwalFarmer.Text), totalUpahFarmer);

            bool hasil = ControllersJadwal.UpdateJadwal(JadwalUpdate);

            if (hasil)
            {
                MessageBox.Show("Jadwal farmer berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSimpanEditFarmer.Visible = false;
                btSimpanEditFarmer.Enabled = false;
                txtTotalUpah.ReadOnly = true;
                txtKeteranganJadwalFarmer.ReadOnly = true;
                PindahPanel(panelJadwal, "Jadwal");
            }
            else
            {
                MessageBox.Show("Gagal menyimpan perubahan ke database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLainnya_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (menuAktif == "Laporan")
                {
                    panelDetailLaporan.Visible = true;
                    txtTanggalJadwalLaporan.Text = dgvLainnya.Rows[e.RowIndex].Cells["tanggal_jadwal"].Value!.ToString();
                    txtWaktuLaporan.Text = dgvLainnya.Rows[e.RowIndex].Cells["waktu_lapor"].Value!.ToString();
                    txtIdLaporan.Text = dgvLainnya.Rows[e.RowIndex].Cells["id_laporan"].Value!.ToString();
                    txtIsiLaporan.Text = dgvLainnya.Rows[e.RowIndex].Cells["isi_laporan"].Value!.ToString();
                    txtIdAnggotaLaporan.Text = dgvLainnya.Rows[e.RowIndex].Cells["id_anggota"].Value!.ToString();
                    txtNamaAnggotaLaporan.Text = dgvLainnya.Rows[e.RowIndex].Cells["nama_anggota"].Value!.ToString();
                    txtIdJadwalLaporan.Text = dgvLainnya.Rows[e.RowIndex].Cells["id_jadwal"].Value!.ToString();
                    txtIsiJadwalLaporan.Text = dgvLainnya.Rows[e.RowIndex].Cells["keterangan_kegiatan"].Value!.ToString();

                    txtTanggalJadwalLaporan.ReadOnly = true;
                    txtIdLaporan.ReadOnly = true;
                    txtIdAnggotaLaporan.ReadOnly = true;
                    txtIsiJadwalLaporan.ReadOnly = true;
                    txtWaktuLaporan.ReadOnly = true;
                    txtIsiLaporan.ReadOnly = true;
                    txtNamaAnggotaLaporan.ReadOnly = true;
                    txtIdJadwalLaporan.ReadOnly = true;
                }
                else if (menuAktif == "Penarikan")
                {
                    string idPenarikan = dgvLainnya.Rows[e.RowIndex].Cells["id_riwayat_penarikan"].Value!.ToString()?.Trim() ?? "";
                    int idRiwayat = Convert.ToInt32(dgvLainnya.Rows[e.RowIndex].Cells["id_riwayat_penarikan"].Value!.ToString());
                    string metode = dgvLainnya.Rows[e.RowIndex].Cells["metode_penarikan"].Value!.ToString()?.Trim() ?? "";
                    string status = dgvLainnya.Rows[e.RowIndex].Cells["status_pencairan"].Value!.ToString()?.Trim() ?? "";
                    string namaAnggota = dgvLainnya.Rows[e.RowIndex].Cells["nama_anggota"].Value!.ToString()?.Trim() ?? "";
                    string nominal = dgvLainnya.Rows[e.RowIndex].Cells["nominal"].Value!.ToString()?.Trim() ?? "";


                    if (metode == "Cash" && status != "Selesai")
                    {
                        DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin mengubah status penarikan dengan ID {idPenarikan} atas nama {namaAnggota} sebesar Rp. {nominal} menjadi 'Selesai'?\n\n" + "(Pastikan uang tunai fisik sudah diserahkan langsung kepada karyawan yang bersangkutan)", "Konfirmasi Penyerahan Uang Tunai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            bool sukses = ControllersPenarikan.KonfirmasiPencairan(idRiwayat);

                            if (sukses)
                            {
                                MessageBox.Show("Status penarikan berhasil diubah menjadi Selesai!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            else
                            {
                                MessageBox.Show("Gagal memperbarui status pencairan di database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

        }

        private void btKembaliLaporan_Click(object sender, EventArgs e)
        {
            panelDetailLaporan.Visible = false;
        }

        private void btTarikSaldo_Click(object sender, EventArgs e)
        {
            panelPenarikan.Visible = true;
            txtAtasNamaPenarikan.Enabled = false;
            txtNoRek.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtAtasNamaPenarikan.Enabled = true;
                txtNoRek.Enabled = false;
                txtNoRek.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtNoRek.Enabled = true;
                txtAtasNamaPenarikan.Enabled = false;
                txtAtasNamaPenarikan.Clear();
            }
        }

        private void btKonfirmasiPenarikan_Click(object sender, EventArgs e)
        {
            if (Validator.ApakahKosong(txtNominalPenarikan.Text) || !Validator.ApakahAngka(txtNominalPenarikan.Text))
            {
                MessageBox.Show("Masukkan nominal penarikan berupa angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal jumlahTarik = Convert.ToDecimal(txtNominalPenarikan.Text);

            if (radioButton1.Checked)
            {

                MetodePenarikanCash aksiCash = new MetodePenarikanCash();
                string namaPengambil = txtAtasNamaPenarikan.Text;

                bool berhasil = aksiCash.MenarikUang(jumlahTarik, owner, namaPengambil);
                if (berhasil)
                {
                    txtAtasNamaPenarikan.Clear();
                    txtNominalPenarikan.Clear();
                }
            }
            else if (radioButton2.Checked)
            {
                MetodePenarikanTransfer aksiTransfer = new MetodePenarikanTransfer();
                string nomorRekening = txtNoRek.Text;

                bool berhasil = aksiTransfer.MenarikUang(jumlahTarik, owner, nomorRekening);
                if (berhasil)
                {
                    txtNoRek.Clear();
                    txtNominalPenarikan.Clear();
                    panelPenarikan.Visible = false;
                    menuAktif = "Laporan";
                    List<Laporan> listAsli = ControllersLaporan.getAllLaporan();
                    var dataUntukGrid = listAsli.Select(o => new
                    {
                        tanggal_jadwal = o.getTanggalJadwal(),
                        Waktu_lapor = o.getWaktuLapor(),
                        id_laporan = o.getIdlaporan(),
                        isi_laporan = o.getIsiLaporan(),
                        id_anggota = o.getIdAnggota(),
                        nama_anggota = o.getNamaAnggota(),
                        id_jadwal = o.getidJadwal(),
                        keterangan_kegiatan = o.getKeteranganKegiatan()
                    }).ToList();
                    dgvLainnya.DataSource = dataUntukGrid;
                    dgvLainnya.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih metode penarikan terlebih dahulu (Cash / Transfer)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCariTanaman_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string kataKunci = txtCariTanaman.Text.Trim();
                if (string.IsNullOrEmpty(kataKunci))
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
                    return;
                }
                List<Tanaman> hasilCari = ControllersTanaman.Cari(kataKunci);
                var dataHasilCariGrid = hasilCari.Select(o => new
                {
                    ID = o.getIdTanaman(),
                    Nama = o.getNamaTanaman(),
                    Harga = o.getHargaTanaman(),
                    Estimasi_Kadaluarsa = o.getEstimasiKadaluarsa()
                }).ToList();

                // Masukkan hasil filter ke dalam DataGridView
                dgvTanaman.DataSource = dataHasilCariGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan pencarian otomatis: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}