using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

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
                using var query1 = new NpgsqlCommand("Select ID_Gudang, Nama_Gudang, Stock, Tanggal_Masuk, ID_Tanaman from Gudang", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataGudang.Add(new Gudang(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Tanpa Nama" : reader.GetString(1),
                        reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                        reader.IsDBNull(3) ? DateTime.Now : reader.GetDateTime(3),
                        reader.IsDBNull(4) ? 0 : reader.GetInt32(4)
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
                    "update Gudang set Nama_Gudang=@Nama_Gudang, NO_TELP=@NO_TELP, Email=@Email, Detail_Alamat=@Detail_Alamat where ID_Gudang=@ID_Gudang", conn);
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
    }
}
