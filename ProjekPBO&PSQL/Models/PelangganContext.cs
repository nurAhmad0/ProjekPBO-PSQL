using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using ProjekPBO_PSQL.Helpers;

namespace ProjekPBO_PSQL.Models
{
    class PelangganContext
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

        public bool ADDPelanggan(Pelanggan pelanggan)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "Insert into pelanggan (ID_pelanggan, Nama_Pelanggan, NO_TELP, Email, Detail_Alamat) values (@ID_pelanggan, @Nama_Pelanggan, @NO_TELP, @Email, @Detail_Alamat)", conn);
                query1.Parameters.AddWithValue("ID_pelanggan", pelanggan.getIdPelanggan());
                query1.Parameters.AddWithValue("Nama_Pelanggan", pelanggan.getNamePelanggan());
                query1.Parameters.AddWithValue("NO_TELP", pelanggan.getNO_TELP());
                query1.Parameters.AddWithValue("Email", pelanggan.getEmail());
                query1.Parameters.AddWithValue("Detail_Alamat", pelanggan.getDetailAlamat());
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

        public bool UpdatePelanggan(Pelanggan pelanggan)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "update pelanggan set Nama_Pelanggan=@Nama_Pelanggan, NO_TELP=@NO_TELP, Email=@Email, Detail_Alamat=@Detail_Alamat where ID_pelanggan=@ID_pelanggan", conn);
                query1.Parameters.AddWithValue("ID_pelanggan", pelanggan.getIdPelanggan());
                query1.Parameters.AddWithValue("Nama_Pelanggan", pelanggan.getNamePelanggan());
                query1.Parameters.AddWithValue("NO_TELP", pelanggan.getNO_TELP());
                query1.Parameters.AddWithValue("Email", pelanggan.getEmail());
                query1.Parameters.AddWithValue("Detail_Alamat", pelanggan.getDetailAlamat());
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

        public bool DelatePelanggan(int id)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("DELETE FROM Pelanggan WHERE id=@id", conn);
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

        public bool? ApakahAdaNOTELP(string NOTELP)
        {
            NOTELP = NOTELP.Trim();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select no_telp from Pelanggan where no_telp ilike @notelp", conn);
                query1.Parameters.AddWithValue("notelp", NOTELP);
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

        public bool? ApakahAdaEmail(string Email)
        {
            Email = Email.Trim();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select email from Pelanggan where email ilike @email", conn);
                query1.Parameters.AddWithValue("email", Email);
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
