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
            string Query1 = @"SELECT o.id_order, o.tanggal_order, o.id_anggota, o.id_pelanggan, od.id_order_detils, od.harga, od.jumlah_produk, od.id_order, od.id_tanaman FROM ""order"" o JOIN order_details od using (id_order)";
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
                        OrderDetails detailBaru = new OrderDetails(idDetail, harga, jumlah, idOrderCur, idTanaman);
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

        public bool SimpanOrder(int idAnggota, int idPelanggan, List<OrderDetails> keranjangBelanja)
        {
            using var conn = DataBaseHelper.GetConnection();

            try
            {
                conn.Open();

                using var cmdOrder = new NpgsqlCommand("SELECT buat_order(@idAnggota, @idPelanggan);", conn);
                cmdOrder.Parameters.AddWithValue("@idAnggota", idAnggota);
                cmdOrder.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                int idOrderBaru = Convert.ToInt32(cmdOrder.ExecuteScalar());
                foreach (OrderDetails OrderD in keranjangBelanja)
                {
                    using var cmdOrderD = new NpgsqlCommand("CALL tambah_item_order(@idOrder, @idTanaman, @jumlah, @harga);", conn);
                    cmdOrderD.Parameters.AddWithValue("@idOrder", idOrderBaru); 
                    cmdOrderD.Parameters.AddWithValue("@idTanaman", OrderD.getIDTanaman());
                    cmdOrderD.Parameters.AddWithValue("@jumlah", OrderD.getJumlahOrder());
                    cmdOrderD.ExecuteNonQuery();
                }
                MessageBox.Show("Transaksi Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal Memproses Transaksi: " + ex.Message, "Peringatan Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
