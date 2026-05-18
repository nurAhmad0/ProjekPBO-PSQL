using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using ProjekPBO_PSQL.Helpers;

namespace ProjekPBO_PSQL.Models
{
    class CRUDPelanggan
    {
        public List<Pelanggan> getAllPelanggan()
        {
            List<Pelanggan> DataPelanggan = new List<Pelanggan>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select ID_pelanggan, Nama_Pelanggan, NO_TELP, Email, Detail_Alamat from Pelanggan", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataPelanggan.Add(new Pelanggan(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Tanpa Nama" : reader.GetString(1),
                        reader.IsDBNull(2) ? "-" : reader.GetString(2),
                        reader.IsDBNull(3) ? "Tidak Ada Email" : reader.GetString(3),
                        reader.IsDBNull(4) ? "Alamat Tidak Ada" : reader.GetString(4)
                        ));
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

            return DataPelanggan;
        }

        public void ADDPelanggan(Pelanggan pelanggan)
        {
            using var conn = DataBaseHelper.GetConnection();
            conn.Open();
            using var query1 = new NpgsqlCommand(
                "Insert into pelanggan (ID_pelanggan, Nama_Pelanggan, NO_TELP, Email, Detail_Alamat) values (@ID_pelanggan, @Nama_Pelanggan, @NO_TELP, @Email, @Detail_Alamat)", conn);
            query1.Parameters.AddWithValue("ID_pelanggan");


    }
    }
}
