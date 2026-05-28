using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    internal class TanamanContext
    {
        public List<Tanaman> GETALLTanaman()
        {
            List<Tanaman> DataTanaman = new List<Tanaman>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select ID_Tanaman, nama_tanaman, harga, estimasi_kadaluarsa from Tanaman", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataTanaman.Add(new Tanaman(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Tanpa Nama" : reader.GetString(1),
                        reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
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

            return DataTanaman;
        }

        public bool ADDTanaman(Tanaman Tanaman)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "INSERT INTO Tanaman (nama_tanaman, harga, estimasi_kadaluarsa) VALUES (@ID_Tanaman, @Nama_Tanaman, @Harga, @Estimasi_Kadaluarsa)", conn);
                query1.Parameters.AddWithValue("ID_Tanaman", Tanaman.getIdTanaman());
                query1.Parameters.AddWithValue("Nama_Tanaman", Tanaman.getNamaTanaman());
                query1.Parameters.AddWithValue("Harga", Tanaman.getHargaTanaman());
                query1.Parameters.AddWithValue("Estimasi_Kadaluarsa", Tanaman.getEstimasiKadaluarsa());
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    isSucces = true;
                }
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Database: " + ex.Message, "Gagal Simpan", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isSucces = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Sistem: " + ex.Message, "Gagal", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isSucces = false;
            }
            return isSucces;
        }

        public bool UpdateTanaman(Tanaman Tanaman)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "update Tanaman set Nama_Tanaman=@Nama_Tanaman, @Harga, @Estimasi_Kadaluarsa where ID_Tanaman=@ID_Tanaman", conn);
                query1.Parameters.AddWithValue("ID_Tanaman", Tanaman.getIdTanaman());
                query1.Parameters.AddWithValue("Nama_Tanaman", Tanaman.getNamaTanaman());
                query1.Parameters.AddWithValue("Harga", Tanaman.getHargaTanaman());
                query1.Parameters.AddWithValue("Estimasi_Kadaluarsa", Tanaman.getEstimasiKadaluarsa());
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    isSucces = true;
                }
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Database: " + ex.Message, "Gagal Simpan", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isSucces = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Sistem: " + ex.Message, "Gagal", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isSucces = false;
            }
            return isSucces;
        }

        public bool DelateTanaman(int id)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("DELETE FROM Tanaman WHERE id=@id", conn);
                query1.Parameters.AddWithValue("id", id);
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    isSucces = true;
                }
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Database: " + ex.Message, "Gagal Hapus", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isSucces = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Sistem: " + ex.Message, "Gagal", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isSucces = false;
            }
            return isSucces;
        }
    }
}
