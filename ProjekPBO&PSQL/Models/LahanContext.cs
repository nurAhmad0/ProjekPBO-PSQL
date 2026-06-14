using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class LahanContext
    {
        public List<Lahan> GetLahanTersedia()
        {
            List<Lahan> daftarLahanTersedia = new List<Lahan>();
            using var conn = DataBaseHelper.GetConnection();

            // Query mencari lahan aktif yang TIDAK memiliki status 'Masih Ditanam' atau 'Pending'
            string query = @"
                SELECT id_lahan, nama_lahan, luas_lahan, status_lahan 
                FROM Lahan 
                WHERE status_lahan = 'Aktif' 
                AND id_lahan NOT IN (
                SELECT id_lahan 
                FROM Penanaman_Lahan 
                WHERE status_penanaman IN ('Masih Ditanam', 'Pending')
                );";

            try
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Sesuaikan properti ini dengan constructor/properti class Lahan milikmu
                    Lahan lahan = new Lahan(
                        Convert.ToInt32(reader["id_lahan"]),
                        reader["nama_lahan"].ToString()!,
                        Convert.ToDecimal(reader["luas_lahan"]),
                        reader["status_lahan"].ToString()!
                    );
                    daftarLahanTersedia.Add(lahan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data lahan tersedia: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return daftarLahanTersedia;
        }


        public List<Lahan> GETALLLahan()
        {
            List<Lahan> DataLahan = new List<Lahan>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select id_lahan, Nama_lahan, Luas_lahan, status_lahan from Lahan", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataLahan.Add(new Lahan(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "-" : reader.GetString(1),
                        reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                        reader.IsDBNull(3) ? "-" : reader.GetString(3)
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

            return DataLahan;
        }

        public bool UPDATELahan(Lahan lahan)
        {
            bool IsSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                var query1 = new NpgsqlCommand(
                    "update Lahan set nama_lahan=@NamaLahan, luas_lahan=@LuasLahan, status_lahan=@statusLahan::status_lahan where id_lahan = @idLahan", conn);
                query1.Parameters.AddWithValue("NamaLahan", lahan.getNamaLahan());
                query1.Parameters.AddWithValue("LuasLahan", lahan.getLuasLahan());
                query1.Parameters.AddWithValue("statusLahan", lahan.getStatusLahan());
                query1.Parameters.AddWithValue("idLahan", lahan.getIdLahan());
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    IsSucces = true;
                }
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Database: " + ex.Message, "Gagal Simpan", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Sistem: " + ex.Message, "Gagal", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return IsSucces;
        }

        public bool AddLahan(Lahan lahan)
        {
            bool IsSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "INSERT INTO Lahan (nama_lahan, luas_lahan, status_lahan) VALUES (@NamaLahan, @LuasLahan, @Status::status_lahan)", conn);
                query1.Parameters.AddWithValue("LuasLahan", lahan.getLuasLahan());
                query1.Parameters.AddWithValue("NamaLahan", lahan.getNamaLahan());
                query1.Parameters.AddWithValue("Status", lahan.getStatusLahan());
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    IsSucces = true;
                }
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Database: " + ex.Message, "Gagal Simpan", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Sistem: " + ex.Message, "Gagal", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return IsSucces;
        }

        public bool DELETELahan(int id)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("CALL hapus_lahan(@id)", conn);
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

        public bool? ApakahAdaNamaLahan(string nama)
        {
            nama = nama.Trim();
            try
            { 
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select nama_lahan from Lahan where nama_lahan ilike @nama", conn);
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
    }
}
