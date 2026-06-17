using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Models
{
    class GudangContext
    {
        public List<Gudang> getAllGudang()
        {
            List<Gudang> DataGudang = new List<Gudang>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select g.ID_Gudang, g.Nama_Gudang, g.Stock, g.Tanggal_Masuk, g.ID_Tanaman, t.nama_tanaman from Gudang g join tanaman t using (id_Tanaman)", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataGudang.Add(new Gudang(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Tanpa Nama" : reader.GetString(1),
                        reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                        reader.IsDBNull(3) ? DateTime.Now : reader.GetDateTime(3),
                        reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                        reader.IsDBNull(5) ? "Tanpa Nama" : reader.GetString(5)
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

            return DataGudang;
        }

        public bool ADDGudang(Gudang Gudang)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "Insert into Gudang (ID_Gudang, Nama_Gudang, Stock, Tanggal_Masuk, ID_Tanaman) values (@ID_Gudang, @Nama_Gudang, @Stock, @Tanggal_Masuk, @ID_Tanaman)", conn);
                query1.Parameters.AddWithValue("ID_Gudang", Gudang.getIDGudang());
                query1.Parameters.AddWithValue("Nama_Gudang", Gudang.getNamaGudang());
                query1.Parameters.AddWithValue("Stock", Gudang.getStock());
                query1.Parameters.AddWithValue("Tanggal_Masuk", Gudang.getTanggalMasuk());
                query1.Parameters.AddWithValue("ID_Tanaman", Gudang.getIDTanaman());
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

        public bool UpdateGudang(Gudang Gudang)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "UPDATE gudang SET nama_gudang=@Nama_Gudang, stock=@Stock, tanggal_masuk=@Tanggal_Masuk, id_tanaman=@ID_Tanaman WHERE id_gudang=@ID_Gudang", conn);
                query1.Parameters.AddWithValue("ID_Gudang", Gudang.getIDGudang());
                query1.Parameters.AddWithValue("Nama_Gudang", Gudang.getNamaGudang());
                query1.Parameters.AddWithValue("Stock", Gudang.getStock());
                query1.Parameters.AddWithValue("Tanggal_Masuk", Gudang.getTanggalMasuk());
                query1.Parameters.AddWithValue("ID_Tanaman", Gudang.getIDTanaman());
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

        public bool DelateGudang(int id)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("DELETE FROM Gudang WHERE id=@id", conn);
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

        public bool? ApakahAdaNamaGudang(string nama)
        {
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select nama_gudang from gudang where nama_gudang = @nama", conn);
                query1.Parameters.AddWithValue("nama", nama);
                using var reader = query1.ExecuteReader();
                if (reader.Read() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public Gudang GetGudangByTanaman(int idTanaman)
        {
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                string sql = "SELECT id_gudang, nama_gudang, stock, tanggal_masuk, id_tanaman FROM gudang WHERE id_tanaman = @idTanaman LIMIT 1";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idTanaman", idTanaman);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Gudang(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetDecimal(2),
                        reader.GetDateTime(3),
                        reader.GetInt32(4),
                        ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mencari gudang: " + ex.Message);
            }
            return null!;
        }
    }
}
