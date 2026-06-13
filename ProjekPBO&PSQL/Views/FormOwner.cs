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
                int idTerpilih = Convert.ToInt32(dgvJadwal.CurrentRow.Cells["ID Jadwal"].Value);
                string tipeJadwal = Convert.ToString(dgvJadwal.CurrentRow.Cells["Tipe Jadwal"].Value)!;
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
                    foreach (DetailAnggotaJadwal anggota in listDetailAnggota)
                    {
                        int rowIndex = dataGAnggotaJadwalFarmer.Rows.Add(anggota.getIdAnggota(), anggota.getNamaAnggota(), anggota.getWaktuJoin(), anggota.getUpahDiterima());

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
                    Order orderTerpilih = JadwalTerpilih.getOrderData();

                    List<OrderDetails> keranjangBelanja = orderTerpilih.getlistOrderdetails();
                    foreach (OrderDetails orderD in keranjangBelanja)
                    {
                        int rowIndex = dataGKeranjangBelanja.Rows.Add(orderD.getNamaTanaman(), orderD.getHarga(), orderD.getJumlahOrder());
                        if (dataGKeranjangBelanja.Columns.Contains("colIdDetail"))
                        {
                            dataGKeranjangBelanja.Columns["colNamaTanaman"]!.HeaderText = "Nama Tanaman";
                            dataGKeranjangBelanja.Columns["colHarga"]!.HeaderText = "Harga (Rp)";
                            dataGKeranjangBelanja.Columns["colHarga"]!.DefaultCellStyle.Format = "N0";
                            dataGKeranjangBelanja.Columns["colJumlah"]!.HeaderText = "Jumlah Keluar";
                            dataGKeranjangBelanja.Columns["colJumlah"]!.DefaultCellStyle.Format = "N0";
                        }
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
    }
}