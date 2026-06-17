using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Models
{
    class OrderContext
    {
        public List<Order> GetALLdataOrder()
        {
            List<Order> DataOrder = new List<Order>();
            string Query1 = @"SELECT o.id_order, o.tanggal_order, o.id_anggota, o.id_pelanggan, od.id_order_details, od.harga, od.jumlah_produk, od.id_order, od.id_tanaman, t.nama_tanaman FROM ""order"" o JOIN order_details od using (id_order) join Tanaman t using (id_tanaman)";
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(Query1, conn);
                using var reader = query1.ExecuteReader();

                while (reader.Read())
                {
                    int idOrderCur = reader.GetInt32(0);
                    Order? orderEksis = null;
                    foreach (Order j in DataOrder)
                    {
                        if (j.getIDOrder() == idOrderCur)
                        {
                            orderEksis = j;
                            break;
                        }
                    }
                    if (orderEksis == null)
                    {
                        DateTime tanggal = reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1);
                        int idAnggota = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                        int idPelanggan = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);

                        orderEksis = new Order(idOrderCur, tanggal, idAnggota, idPelanggan);
                        DataOrder.Add(orderEksis);
                    }
                    if (!reader.IsDBNull(4))
                    {
                        int idDetail = reader.GetInt32(4);
                        decimal harga = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                        decimal jumlah = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                        int idOrderSaja = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                        int idTanaman = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
                        string namaTanaman = reader.IsDBNull(9) ? "-" : reader.GetString(9);
                        OrderDetails detailBaru = new OrderDetails(idDetail, harga, jumlah, idOrderCur, idTanaman, namaTanaman);
                        orderEksis.getlistOrderdetails().Add(detailBaru);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return DataOrder;
        }

        public int SimpanOrder(int idAnggota, DateTime Tanggal, int idPelanggan, List<OrderDetails> keranjangBelanja)
        {
            if (keranjangBelanja == null || keranjangBelanja.Count == 0)
            {
                MessageBox.Show("Keranjang belanja kosong! Tidak ada data untuk disimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using var conn = DataBaseHelper.GetConnection();
            NpgsqlTransaction? transaksi = null;

            try
            {
                conn.Open();
                transaksi = conn.BeginTransaction();

                // 1. Ambil ID Order Baru dari fungsi buat_order
                using var cmdOrder = new NpgsqlCommand("SELECT buat_order(@idAnggota, @Tanggal, @idPelanggan);", conn);
                cmdOrder.Parameters.AddWithValue("@idAnggota", idAnggota);
                cmdOrder.Parameters.Add("@Tanggal", NpgsqlTypes.NpgsqlDbType.Date).Value = Tanggal.Date;
                cmdOrder.Parameters.AddWithValue("@idPelanggan", idPelanggan);

                int idOrderBaru = Convert.ToInt32(cmdOrder.ExecuteScalar());

                // 2. Looping isi keranjang untuk dimasukkan ke detail order
                foreach (OrderDetails OrderD in keranjangBelanja)
                {
                    using var cmdOrderD = new NpgsqlCommand("CALL tambah_order_details(@idOrder, @idTanaman, @jumlah, @harga);", conn);

                    cmdOrderD.Parameters.AddWithValue("@idOrder", idOrderBaru);
                    cmdOrderD.Parameters.AddWithValue("@idTanaman", OrderD.getIDTanaman());

                    // PERBAIKAN UTAMA: Tegaskan tipe data ke NpgsqlDbType.Numeric agar sinkron dengan NUMERIC(10,2) di Postgres
                    cmdOrderD.Parameters.Add("@jumlah", NpgsqlTypes.NpgsqlDbType.Numeric).Value = Convert.ToDecimal(OrderD.getJumlahOrder());
                    cmdOrderD.Parameters.Add("@harga", NpgsqlTypes.NpgsqlDbType.Numeric).Value = Convert.ToDecimal(OrderD.getHarga());

                    cmdOrderD.ExecuteNonQuery();
                }

                // Jika semua item berhasil masuk tanpa crash, komit transaksi
                transaksi.Commit();

                // Catatan: MessageBox sukses di sini bisa dipertahankan, 
                // atau dihapus jika kamu ingin memunculkan pesan sukses di Form saja agar tidak double.
                return idOrderBaru;
            }
            catch (NpgsqlException ex)
            {
                if (transaksi != null && conn.State == System.Data.ConnectionState.Open)
                {
                    transaksi.Rollback();
                }
                // Sekarang, jika database melempar RAISE EXCEPTION, pesan aslinya AKAN PASTI MUNCUL di sini!
                MessageBox.Show("Gagal Memproses Transaksi di Database: " + ex.Message, "Peringatan Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            catch (Exception ex)
            {
                if (transaksi != null && conn.State == System.Data.ConnectionState.Open)
                {
                    transaksi.Rollback();
                }
                MessageBox.Show("Terjadi kesalahan sistem C#: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
