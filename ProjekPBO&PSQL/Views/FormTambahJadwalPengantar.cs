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
    public partial class FormTambahJadwalPengantaran : Form
    {
        JadwalController jadwalController = new JadwalController();
        TanamanController tanamanController = new TanamanController();
        PelangganController pelangganController = new PelangganController();
        OrangController orangController = new OrangController();
        OrderController orderController = new OrderController();

        public FormTambahJadwalPengantaran()
        {
            InitializeComponent();
            IsiComboBoxLahanDanTanaman();
            txtTipeJadwal.ReadOnly = true;
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

        private void IsiComboBoxLahanDanTanaman()
        {
            try
            {
                List<Pelanggan> daftarPelanggan = pelangganController.GetAllPelanggan();
                List<Tanaman> daftarTanaman = tanamanController.GetAllTanaman();
                List<Pengantar> daftarPengantar = orangController.GetAllOrangPengantar();

                List<Pengantar> daftarPelaggan = daftarPengantar.FindAll(l => l.getStatus() == "Aktif");

                cbPelanggan.DataSource = daftarPelanggan;
                cbPelanggan.DisplayMember = "namaPelanggan";
                cbPelanggan.ValueMember = "idPelanggan";

                cbTanaman.DataSource = daftarTanaman;
                cbTanaman.DisplayMember = "nama_tanaman";
                cbTanaman.ValueMember = "id_tanaman";

                cbPengantar.DataSource = daftarPengantar;
                cbPengantar.DisplayMember = "namaPengantar";
                cbPengantar.ValueMember = "idPengantar";

                cbTanaman.SelectedIndex = -1;
                cbPelanggan.SelectedIndex = -1;
                cbPengantar.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data komponen: " + ex.Message, "Error Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cbPengantar.SelectedIndex == -1 || cbPengantar.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih Lahan terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbPelanggan.SelectedIndex == -1 || cbPelanggan.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih Pelanggan terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Validator.ApakahKosong(txtKeterangan.Text))
            {
                MessageBox.Show("Keterangan kegiatan tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKeterangan.Focus();
                return;
            }

            if (Validator.ApakahKosong(txtTotalUpah.Text))
            {
                MessageBox.Show("Total upah tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalUpah.Focus();
                return;
            }

            if (!decimal.TryParse(txtTotalUpah.Text.Trim(), out decimal totalUpah) || totalUpah < 0)
            {
                MessageBox.Show("Total upah harus berupa angka nominal yang valid!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalUpah.Focus();
                return;
            }

            panel2.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btTambahKeranjang_Click(object sender, EventArgs e)
        {
            if (Validator.ApakahKosong(txtJumlahDibeli.Text))
            {
                MessageBox.Show("Jumlah tanaman yang ditanam tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahDibeli.Focus();
                return;
            }

            if (!int.TryParse(txtJumlahDibeli.Text.Trim(), out int jumlahDitanam) || jumlahDitanam <= 0)
            {
                MessageBox.Show("Jumlah ditanam harus berupa angka bulat dan lebih dari 0!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlahDibeli.Focus();
                return;
            }

            if (cbTanaman.SelectedIndex == -1 || cbTanaman.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih Jenis Tanaman terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataKeranjangBelanja.Columns.Count == 0)
            {
                dataKeranjangBelanja.Columns.Add("colId", "ID Tanaman");
                dataKeranjangBelanja.Columns.Add("colNama", "Nama Tanaman");
                dataKeranjangBelanja.Columns.Add("colHarga", "Harga Satuan");
                dataKeranjangBelanja.Columns.Add("colJumlah", "Jumlah Beli");
                dataKeranjangBelanja.Columns.Add("colTotal", "Total Harga");
                dataKeranjangBelanja.Columns["colId"]!.Visible = false;
                dataKeranjangBelanja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }


            string nameTanaman = cbTanaman.Text.Trim();
            int idTanaman = (int)cbTanaman.SelectedValue;

            decimal BanyakTanamanDibeli = Convert.ToDecimal(txtJumlahDibeli.Text.Trim());

            Tanaman TanamanTerpilih = tanamanController.Cari(idTanaman)!;
            decimal hargaTanaman = TanamanTerpilih.getHargaTanaman();
            decimal totalHarga = hargaTanaman * BanyakTanamanDibeli;
            bool sudahAda = false;

            foreach (DataGridViewRow row in dataKeranjangBelanja.Rows)
            {
                if (row.Cells["colId"].Value != null && Convert.ToInt32(row.Cells["colId"].Value) == idTanaman)
                {
                    decimal jumlahLama = Convert.ToInt32(row.Cells["colJumlah"].Value);
                    decimal jumlahBaru = jumlahLama + BanyakTanamanDibeli;
                    row.Cells["colJumlah"].Value = jumlahBaru;
                    row.Cells["colTotal"].Value = Convert.ToDecimal(jumlahBaru) * hargaTanaman;
                    sudahAda = true;
                    break;
                }
            }

            if (!sudahAda)
            {
                dataKeranjangBelanja.Rows.Add(idTanaman, nameTanaman, hargaTanaman, BanyakTanamanDibeli, totalHarga);
            }

            decimal totalHargaSemua = 0;

            foreach (DataGridViewRow row in dataKeranjangBelanja.Rows)
            {
                totalHargaSemua += Convert.ToInt32(row.Cells["colJumlah"].Value);
            }

            lbTotalKeranjang.Text = totalHargaSemua.ToString();

        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (dataKeranjangBelanja.CurrentRow == null || dataKeranjangBelanja.CurrentRow.Index < 0)
            {
                MessageBox.Show("Silakan pilih baris tanaman di dalam keranjang yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus tanaman ini dari keranjang?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int indexSengklek = dataKeranjangBelanja.CurrentRow.Index;
                    dataKeranjangBelanja.Rows.RemoveAt(indexSengklek);
                    MessageBox.Show("Item berhasil dihapus dari keranjang.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btBuatJadwal_Click(object sender, EventArgs e)
        {
            DateTime tanggalTerpilih = dtpTanggal.Value;
            int idPelanggan = (int)cbPelanggan.SelectedValue!;
            Pelanggan pelangganTerpilih = pelangganController.Cari(idPelanggan)!;
            int idPengantar = (int)cbPengantar.SelectedValue!;

            List<OrderDetails> daftarBelanja = new List<OrderDetails>();

            foreach (DataGridViewRow row in dataKeranjangBelanja.Rows)
            {
                if (row.Cells["colId"].Value != null)
                {
                    int idTanaman = Convert.ToInt32(row.Cells["colId"].Value);
                    decimal harga = Convert.ToDecimal(row.Cells["colHarga"].Value);
                    decimal jumlah = Convert.ToDecimal(row.Cells["colJumlah"].Value);
                    OrderDetails detail = new OrderDetails(0, harga, jumlah, 0, idTanaman);
                    daftarBelanja.Add(detail);
                }
            }

            if (daftarBelanja.Count == 0)
            {
                MessageBox.Show("Keranjang belanja masih kosong! Silakan tambah tanaman terlebih dahulu.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool statusOrder = orderController.simpanOrder(idPengantar, tanggalTerpilih, idPelanggan, daftarBelanja);
            if (statusOrder == true)
            {
                Order orderData = new Order(0, tanggalTerpilih, idPengantar, idPelanggan);
                foreach (OrderDetails od in daftarBelanja)
                {
                    orderData.getlistOrderdetails().Add(od);
                }
                JadwalPengantaran jadwalbaru = new JadwalPengantaran(0,Convert.ToDateTime(dtpTanggal.Text), txtKeterangan.Text, 1, "Pengantar", pelangganTerpilih.getNamePelanggan(), pelangganTerpilih.getNO_TELP(), pelangganTerpilih.getDetailAlamat(), idPelanggan, Convert.ToDecimal(txtTotalUpah.Text.Trim()), orderData);
                jadwalController.tambahJadwal(jadwalbaru);
                dataKeranjangBelanja.Rows.Clear();
                txtKeterangan.Clear();
                txtTipeJadwal.Clear();
                txtTotalUpah.Clear();
                txtJumlahDibeli.Clear();
                lbTotalKeranjang.Text = "0";
                cbTanaman.SelectedIndex = -1;
                cbPelanggan.SelectedIndex = -1;
                cbPengantar.SelectedIndex = -1;
            }
        }
    }
}