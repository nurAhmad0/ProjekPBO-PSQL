using ProjekPBO_PSQL.Controllers;
using ProjekPBO_PSQL.Helpers;
using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Views
{
    public partial class FormKaryawan : Form
    {
        OrangController controllersOrang = new OrangController();
        JadwalController controllersJadwal = new JadwalController();
        RiwayatPenarikanController controllersPenarikan = new RiwayatPenarikanController();
        LaporanController controllersLaporan = new LaporanController();
        int idKaryawan;
        Orang Karyawan;
        int idRole;
        public FormKaryawan(int idKaryawan, int idRole)
        {
            InitializeComponent();
            this.idKaryawan = idKaryawan;
            Karyawan = controllersOrang.Cari(idKaryawan)!;
            this.idRole = idRole;
            if (idRole == 2)
            {

            }
            else if (idRole == 3)
            {
                btnJadwal.Visible = false;
                btnJadwal.Enabled = false;
            }
            lblNama.Text = Karyawan.getName();
            lbSaldo.Text = Karyawan.getSaldo().ToString("N0");
            DateTime tanggalSekarang = DateTime.Today;
            lblTanggal.Text = tanggalSekarang.ToString("dd MMMM yyyy");
            PindahPanel(panelJadwlDiterima, "Jadwal Diterima");
            try
            {
                DataTable dtJadwal = AmbilDataJadwalSesuaiRole();

                DataView viewJadwalSaya = new DataView(dtJadwal);
                viewJadwalSaya.RowFilter = $"(id_anggota = {idKaryawan}) AND (status_global IN ('Dalam Pengerjaan', 'Sudah Dikerjakan'))";

                dataGridJadwalDiterima.DataSource = viewJadwalSaya;
                dataGridJadwalDiterima.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridJadwalDiterima.Columns.Contains("id_jadwal"))
                {
                    dataGridJadwalDiterima.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                    dataGridJadwalDiterima.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                    dataGridJadwalDiterima.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan Kegiatan";
                    dataGridJadwalDiterima.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                    dataGridJadwalDiterima.Columns["banyaknya_anggota"]!.HeaderText = "Sisa Kuota";
                    dataGridJadwalDiterima.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                    dataGridJadwalDiterima.Columns["status_global"]!.HeaderText = "Status";
                    dataGridJadwalDiterima.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";

                    if (dataGridJadwalDiterima.Columns.Contains("id_anggota"))
                        dataGridJadwalDiterima.Columns["id_anggota"]!.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan jadwal diterima: " + ex.Message, "Error Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormFarmer_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
            panelPenarikan.Visible = false;
            panelHistoriPenarikan.Visible = false;
            panelLaporan.Visible = false;
            panelJadwlDiterima.Visible = false;

            panelTarget.Visible = true;
            panelTarget.BringToFront();
        }

        private void btnNavJadwal_Click(object sender, EventArgs e)
        {
            if (idRole == 3)
            {
                MessageBox.Show("Daftar pemilihan jadwal mandiri hanya tersedia untuk Farmer.\nJadwal pengantaran Anda akan ditentukan langsung oleh Owner.",
                                "Akses Terbatas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PindahPanel(panelJadwal, "Jadwal");
            try
            {
                DataTable dtJadwal = controllersJadwal.GetAllJadwalFarmerHariIni();
                DataView viewBelumDipilih = new DataView(dtJadwal);
                viewBelumDipilih.RowFilter = $"(id_anggota IS NULL OR id_anggota <> {idKaryawan}) AND ((status_global = 'Belum Dikerjakan') OR (status_global = 'Dalam Pengerjaan' AND banyaknya_anggota > 0))";

                dgvJadwal.DataSource = viewBelumDipilih;
                dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvJadwal.Columns.Contains("id_jadwal"))
                {
                    dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                    dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                    dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan Kegiatan";
                    dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                    dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Sisa Kuota Pekerja";
                    dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                    dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
                    dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";
                    if (dgvJadwal.Columns.Contains("id_anggota"))
                        dgvJadwal.Columns["id_anggota"]!.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan jadwal hari ini ke tabel: " + ex.Message, "Error Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNavPenarikan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelPenarikan, "Penarikan Saldo");
        }

        private void btnNavHistori_Click(object sender, EventArgs e)
        {
            PindahPanel(panelHistoriPenarikan, "Histori Penarikan");
            try
            {
                DataTable dtPenarikanAll = controllersPenarikan.TampilSemuaPenarikan();
                DataView viewHistoriSaya = new DataView(dtPenarikanAll);
                viewHistoriSaya.RowFilter = $"id_anggota = {idKaryawan}";

                dgvHistori.DataSource = viewHistoriSaya;
                dgvHistori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                {
                    dgvHistori.Columns["id_penarikan"]!.HeaderText = "ID Penarikan";
                    dgvHistori.Columns["nominal_penarikan"]!.HeaderText = "Nominal (Rp)";
                    dgvHistori.Columns["tanggal_penarikan"]!.HeaderText = "Tanggal";
                    dgvHistori.Columns["metode_penarikan"]!.HeaderText = "Metode";
                    dgvHistori.Columns["status_penarikan"]!.HeaderText = "Status";
                    dgvHistori.Columns["nominal_penarikan"]!.DefaultCellStyle.Format = "N0";
                    if (dgvHistori.Columns.Contains("id_penarikan"))
                        dgvHistori.Columns["id_penarikan"]!.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan histori penarikan: " + ex.Message, "Error Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNavLaporan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelLaporan, "Laporan");
            try
            {
                List<Laporan> listLaporanAll = controllersLaporan.getAllLaporan();
                var laporanSaya = listLaporanAll
                    .Where(l => l.getIdAnggota() == idKaryawan)
                    .Select(l => new
                    {
                        IDLaporan = l.getIdlaporan(),
                        IsiLaporan = l.getIsiLaporan(),
                        WaktuLapor = l.getWaktuLapor(),
                        IDJadwal = l.getidJadwal(),
                        KeteranganJadwal = l.getKeteranganKegiatan(),
                        TanggalJadwal = l.getTanggalJadwal()
                    })
                    .ToList();
                dgvLaporan.DataSource = laporanSaya;
                dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvLaporan.Columns.Contains("IDLaporan"))
                {
                    dgvLaporan.Columns["IDLaporan"]!.HeaderText = "ID Laporan";
                    dgvLaporan.Columns["IsiLaporan"]!.HeaderText = "Isi Laporan Karyawan";
                    dgvLaporan.Columns["WaktuLapor"]!.HeaderText = "Waktu Dilaporkan";
                    dgvLaporan.Columns["IDJadwal"]!.HeaderText = "ID Jadwal";
                    dgvLaporan.Columns["KeteranganJadwal"]!.HeaderText = "Detail Kegiatan Pekerjaan";
                    dgvLaporan.Columns["TanggalJadwal"]!.HeaderText = "Tanggal Jadwal";
                    dgvLaporan.Columns["WaktuLapor"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvLaporan.Columns["TanggalJadwal"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat histori laporan Anda: " + ex.Message, "Error Tampilan Laporan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambahLaporan_Click(object sender, EventArgs e)
        {
            LoadJadwalKeComboBox();
            PindahPanel(panelBuatLaporan, "Buat laporan");
        }

        private void dgvJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPilihJadwal_Click(object sender, EventArgs e)
        {
            if (dgvJadwal.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris jadwal terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sisaKuota = Convert.ToInt32(dgvJadwal.CurrentRow.Cells["banyaknya_anggota"].Value);

            if (sisaKuota <= 0)
            {
                MessageBox.Show("Maaf, kuota pekerja untuk jadwal ini sudah penuh!", "Kuota Habis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTerpilih = Convert.ToInt32(dgvJadwal.CurrentRow.Cells["id_jadwal"].Value);

                Jadwal JadwalTerpilih = controllersJadwal.GetAllJadwalFarmer(idTerpilih)!;
                if (JadwalTerpilih == null)
                {
                    MessageBox.Show("Data Jadwal tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool hasil = controllersJadwal.TambahDetailJadwal(idKaryawan, idTerpilih);
                if (hasil)
                {
                    MessageBox.Show("Berhasil bergabung ke dalam jadwal pekerjaan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtJadwal = controllersJadwal.GetAllJadwalFarmerHariIni();
                    DataView viewBelumDipilih = new DataView(dtJadwal);
                    viewBelumDipilih.RowFilter = $"(id_anggota IS NULL OR id_anggota <> {idKaryawan}) AND ((status_global = 'Belum Dikerjakan') OR (status_global = 'Dalam Pengerjaan' AND banyaknya_anggota > 0))";

                    dgvJadwal.DataSource = viewBelumDipilih;
                    dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvJadwal.Columns.Contains("id_jadwal"))
                    {
                        dgvJadwal.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                        dgvJadwal.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                        dgvJadwal.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan Kegiatan";
                        dgvJadwal.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                        dgvJadwal.Columns["banyaknya_anggota"]!.HeaderText = "Sisa Kuota Pekerja";
                        dgvJadwal.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                        dgvJadwal.Columns["status_global"]!.HeaderText = "Status";
                        dgvJadwal.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";

                        if (dgvJadwal.Columns.Contains("id_anggota"))
                            dgvJadwal.Columns["id_anggota"]!.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Gagal bergabung ke dalam jadwal.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memproses pengambilan data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void btJadwal_Click(object sender, EventArgs e)
        {

            PindahPanel(panelJadwlDiterima, "Jadwal Diterima");
            try
            {
                DataTable dtJadwal = AmbilDataJadwalSesuaiRole();

                DataView viewJadwalSaya = new DataView(dtJadwal);
                viewJadwalSaya.RowFilter = $"(id_anggota = {idKaryawan}) AND (status_global IN ('Dalam Pengerjaan', 'Sudah Dikerjakan'))";

                dataGridJadwalDiterima.DataSource = viewJadwalSaya;
                dataGridJadwalDiterima.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dataGridJadwalDiterima.Columns.Contains("id_jadwal"))
                {
                    dataGridJadwalDiterima.Columns["id_jadwal"]!.HeaderText = "ID Jadwal";
                    dataGridJadwalDiterima.Columns["tanggal"]!.HeaderText = "Tanggal Kegiatan";
                    dataGridJadwalDiterima.Columns["keterangan_kegiatan"]!.HeaderText = "Keterangan Kegiatan";
                    dataGridJadwalDiterima.Columns["text_tipe_jadwal"]!.HeaderText = "Tipe Jabatan";
                    dataGridJadwalDiterima.Columns["banyaknya_anggota"]!.HeaderText = "Sisa Kuota";
                    dataGridJadwalDiterima.Columns["total_upah"]!.HeaderText = "Total Upah (Rp)";
                    dataGridJadwalDiterima.Columns["status_global"]!.HeaderText = "Status";
                    dataGridJadwalDiterima.Columns["total_upah"]!.DefaultCellStyle.Format = "N0";

                    if (dataGridJadwalDiterima.Columns.Contains("id_anggota"))
                        dataGridJadwalDiterima.Columns["id_anggota"]!.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan jadwal diterima: " + ex.Message, "Error Tampilan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridJadwalDiterima.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu baris jadwal terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTerpilih = Convert.ToInt32(dataGridJadwalDiterima.CurrentRow.Cells["id_jadwal"].Value);
                Jadwal JadwalTerpilih = null!;

                if (idRole == 2)
                {
                    JadwalTerpilih = controllersJadwal.GetAllJadwalFarmer(idTerpilih)!;
                }
                else if (idRole == 3)
                {
                    JadwalTerpilih = controllersJadwal.GetAllJadwalPengantaran(idTerpilih)!;
                }

                if (JadwalTerpilih == null)
                {
                    MessageBox.Show("Data Jadwal tidak ditemukan di database!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult pilihan = MessageBox.Show("Bagaimana status akhir dari jadwal ini?\n\n" + "Klik [YES] jika Selesai / Sudah Dikerjakan.\n" + "Klik [NO] jika Gagal dikerjakan.", "Konfirmasi Status Jadwal", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                string statusBaru = "";
                if (pilihan == DialogResult.Yes)
                {
                    statusBaru = "Sudah Dikerjakan";
                }
                else if (pilihan == DialogResult.No)
                {
                    statusBaru = "Gagal";
                }
                else
                {
                    return;
                }

                bool hasil = controllersJadwal.UpdateStatusjadwal(JadwalTerpilih, statusBaru);
                if (hasil)
                {
                    MessageBox.Show("Berhasil mengubah status jadwal!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable dtJadwal = AmbilDataJadwalSesuaiRole();

                    DataView viewJadwalSaya = new DataView(dtJadwal);
                    viewJadwalSaya.RowFilter = $"(id_anggota = {idKaryawan}) AND (status_global IN ('Dalam Pengerjaan', 'Sudah Dikerjakan'))";

                    dataGridJadwalDiterima.DataSource = viewJadwalSaya;

                    if (dataGridJadwalDiterima.Columns.Contains("id_anggota"))
                    {
                        dataGridJadwalDiterima.Columns["id_anggota"]!.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Gagal mengubah status jadwal.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memproses data: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (jumlahTarik > Convert.ToDecimal(Karyawan.getSaldo()))
            {
                MessageBox.Show("Maaf, saldo Anda tidak mencukupi untuk melakukan penarikan ini!", "Saldo Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radioButton1.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtAtasNamaPenarikan.Text))
                {
                    MessageBox.Show("Silakan isi nama pengambil untuk penarikan tunai/cash!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MetodePenarikanCash aksiCash = new MetodePenarikanCash();
                string namaPengambil = txtAtasNamaPenarikan.Text;
                bool berhasil = aksiCash.MenarikUang(jumlahTarik, Karyawan, namaPengambil);
                if (berhasil)
                {
                    MessageBox.Show("Penarikan tunai berhasil diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAtasNamaPenarikan.Clear();
                    txtNominalPenarikan.Clear();
                    lbSaldo.Text = Karyawan.getSaldo().ToString("N0");
                }
            }
            else if (radioButton2.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtNoRek.Text))
                {
                    MessageBox.Show("Silakan isi nomor rekening tujuan transfer!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MetodePenarikanTransfer aksiTransfer = new MetodePenarikanTransfer();
                string nomorRekening = txtNoRek.Text;
                bool berhasil = aksiTransfer.MenarikUang(jumlahTarik, Karyawan, nomorRekening);
                if (berhasil)
                {
                    MessageBox.Show("Penarikan transfer berhasil diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNoRek.Clear();
                    txtNominalPenarikan.Clear();
                    lbSaldo.Text = Karyawan.getSaldo().ToString("N0");
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih metode penarikan terlebih dahulu (Cash / Transfer)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private DataTable AmbilDataJadwalSesuaiRole()
        {
            if (idRole == 2)
            {
                return controllersJadwal.GetAllJadwalFarmerHariIni();
            }
            else if (idRole == 3)
            {
                return controllersJadwal.GetAllJadwalPengantaranHariIni();
            }
            return new DataTable();
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            PindahPanel(panelLaporan, "Laporan");
            txtTextLaporan.Clear();
        }

        private void btBuatLaporan_Click(object sender, EventArgs e)
        {
            if (cbPilihJadwal.SelectedIndex == -1 || cbPilihJadwal.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih jadwal yang ingin dilaporkan terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTextLaporan.Text))
            {
                MessageBox.Show("Silakan isi teks laporan terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idJadwalTerpilih = Convert.ToInt32(cbPilihJadwal.SelectedValue);
                string isiLaporan = txtTextLaporan.Text;
                Laporan laporanBaru = new Laporan(0, isiLaporan, DateTime.Now, idJadwalTerpilih, idKaryawan, "", "", DateTime.Now);
                bool berhasil = controllersLaporan.TambahLaporan(laporanBaru);
                if (berhasil)
                {
                    MessageBox.Show("Laporan kegiatan berhasil disimpan ke sistem!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTextLaporan.Clear();
                    cbPilihJadwal.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan laporan. Silakan periksa kembali isi laporan Anda.", "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem saat memproses laporan: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadJadwalKeComboBox()
        {
            try
            {
                DataTable dtJadwal = AmbilDataJadwalSesuaiRole();
                DataView viewJadwalSaya = new DataView(dtJadwal);
                viewJadwalSaya.RowFilter = $"(id_anggota = {idKaryawan}) AND (status_global IN ('Dalam Pengerjaan', 'Sudah Dikerjakan'))";
                cbPilihJadwal.DataSource = viewJadwalSaya;
                cbPilihJadwal.ValueMember = "id_jadwal";
                cbPilihJadwal.DisplayMember = "keterangan_kegiatan";
                if (viewJadwalSaya.Count == 0)
                {
                    cbPilihJadwal.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar jadwal ke pilihan laporan: " + ex.Message,
                                "Error Pilihan Jadwal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusLaporan_Click(object sender, EventArgs e)
        {
            if (dgvLaporan.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih laporan yang ingin dihapus dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idLaporanTerpilih = Convert.ToInt32(dgvLaporan.CurrentRow.Cells["IDLaporan"].Value);
            DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus laporan dengan ID {idLaporanTerpilih}?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                controllersLaporan.DeleteLaporan(idLaporanTerpilih);
                List<Laporan> listLaporanAll = controllersLaporan.getAllLaporan();
                var laporanSaya = listLaporanAll
                    .Where(l => l.getIdAnggota() == idKaryawan)
                    .Select(l => new
                    {
                        IDLaporan = l.getIdlaporan(),
                        IsiLaporan = l.getIsiLaporan(),
                        WaktuLapor = l.getWaktuLapor(),
                        IDJadwal = l.getidJadwal(),
                        KeteranganJadwal = l.getKeteranganKegiatan(),
                        TanggalJadwal = l.getTanggalJadwal()
                    })
                    .ToList();
                dgvLaporan.DataSource = laporanSaya;
                dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvLaporan.Columns.Contains("IDLaporan"))
                {
                    dgvLaporan.Columns["IDLaporan"]!.HeaderText = "ID Laporan";
                    dgvLaporan.Columns["IsiLaporan"]!.HeaderText = "Isi Laporan Karyawan";
                    dgvLaporan.Columns["WaktuLapor"]!.HeaderText = "Waktu Dilaporkan";
                    dgvLaporan.Columns["IDJadwal"]!.HeaderText = "ID Jadwal";
                    dgvLaporan.Columns["KeteranganJadwal"]!.HeaderText = "Detail Kegiatan Pekerjaan";
                    dgvLaporan.Columns["TanggalJadwal"]!.HeaderText = "Tanggal Jadwal";
                    dgvLaporan.Columns["WaktuLapor"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvLaporan.Columns["TanggalJadwal"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
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

        private void btKembaliPenarikan_Click(object sender, EventArgs e)
        {
            PindahPanel(panelPenarikan, "Penarikan Saldo");
        }

        private void btLOGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Orang ownerPilihan = controllersOrang.Cari(idKaryawan)!;
                if (ownerPilihan != null)
                {
                    lbSaldo.Text = ownerPilihan.getSaldo().ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan pencarian otomatis: " + ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
