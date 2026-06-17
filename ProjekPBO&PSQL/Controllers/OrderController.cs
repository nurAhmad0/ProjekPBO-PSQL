using Npgsql;
using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    class OrderController
    {
        OrderContext Context = new OrderContext();

        public List<Order> getAllDataOrder()
        {
            return Context.GetALLdataOrder();
        }

        public int simpanOrder(int idAnggota,DateTime Tanggal, int idPelanggan, List<OrderDetails> keranjang)
        {
            if (idAnggota <= 0)
            {
                MessageBox.Show("Sesi Anggota tidak valid! Silakan login ulang.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (idPelanggan <= 0)
            {
                MessageBox.Show("Silakan pilih pelanggan terlebih dahulu!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (keranjang == null || keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang belanja masih kosong! Tidak ada item untuk diproses.", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            try
            {
                int hasil = Context.SimpanOrder(idAnggota, Tanggal, idPelanggan, keranjang);

                if (hasil > 0)
                {
                    MessageBox.Show("Transaksi Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return hasil;
                }
                else
                {
                    MessageBox.Show("Transaksi Gagal Disimpan ke Database.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal Memproses Transaksi di Database: " + ex.Message, "Peringatan Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
