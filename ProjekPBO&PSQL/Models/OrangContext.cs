using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjekPBO_PSQL.Models
{
    class OrangContext
    {
        public List<Farmer> getAllOrangFarmer()
        {
            List<Farmer> DataOrangFarmer = new List<Farmer>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "SELECT ap.id_anggota, ap.nama_anggota, ap.no_telp, ap.saldo, ap.tanggal_lahir, ap.email, ap.status_kerja, ap.id_Role, ap.username, ap.password FROM anggota_perusahaan ap INNER JOIN Role r ON ap.id_role = r.id_role where r.nama_role = 'Farmer';", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataOrangFarmer.Add(new Farmer(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Tanpa Nama" : reader.GetString(1),
                        reader.IsDBNull(2) ? "Tanpa NO Telp" : reader.GetString(2),
                        reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                        reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4),
                        reader.IsDBNull(5) ? "Tidak Ada Email" : reader.GetString(5),
                        reader.IsDBNull(6) ? "Tidak Ada Status Kerja" : reader.GetString(6),
                        reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                        reader.IsDBNull(8) ? "-" : reader.GetString(8),
                        reader.IsDBNull(9) ? "-" : reader.GetString(9)
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

            return DataOrangFarmer;
        }

        public List<Pengantar> getAllOrangPengantar()
        {
            List<Pengantar> DataOrangPengantar = new List<Pengantar>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "SELECT ap.id_anggota, ap.nama_anggota, ap.no_telp, ap.saldo, ap.tanggal_lahir, ap.email, ap.status_kerja, ap.id_Role, ap.username, ap.password FROM anggota_perusahaan ap INNER JOIN Role r ON ap.id_role = r.id_role where r.nama_role = 'Pengantar';", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataOrangPengantar.Add(new Pengantar(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Tanpa Nama" : reader.GetString(1),
                        reader.IsDBNull(2) ? "Tanpa NO Telp" : reader.GetString(2),
                        reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                        reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4),
                        reader.IsDBNull(5) ? "Tidak Ada Email" : reader.GetString(5),
                        reader.IsDBNull(6) ? "Tidak Ada Status Kerja" : reader.GetString(6),
                        reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                        reader.IsDBNull(8) ? "-" : reader.GetString(8),
                        reader.IsDBNull(9) ? "-" : reader.GetString(9)
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

            return DataOrangPengantar;
        }

        public List<Owner> getAllOrangOwner()
        {
            List<Owner> DataOrangOwner = new List<Owner>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "SELECT ap.id_anggota, ap.nama_anggota, ap.no_telp, ap.saldo, ap.tanggal_lahir, ap.email, ap.status_kerja, ap.id_Role, ap.username, ap.password FROM anggota_perusahaan ap INNER JOIN Role r ON ap.id_role = r.id_role where r.nama_role = 'Owner';", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataOrangOwner.Add(new Owner(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Tanpa Nama" : reader.GetString(1),
                        reader.IsDBNull(2) ? "Tanpa NO Telp" : reader.GetString(2),
                        reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                        reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4),
                        reader.IsDBNull(5) ? "Tidak Ada Email" : reader.GetString(5),
                        reader.IsDBNull(6) ? "Tidak Ada Status Kerja" : reader.GetString(6),
                        reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                        reader.IsDBNull(8) ? "-" : reader.GetString(8),
                        reader.IsDBNull(9) ? "-" : reader.GetString(9)
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

            return DataOrangOwner;
        }

        public bool ADDOrang(Orang Orang)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "INSERT INTO anggota_perusahaan (id_anggota, nama_anggota, no_telp, tanggal_lahir, email, status_kerja, saldo, username, password, id_role) VALUES  (@Id_anggota, @Nama_anggota, @No_telp, @Tanggal_lahir, @Email, @Status_kerja, @Saldo, @Username, @Password, @Id_role)", conn);
                query1.Parameters.AddWithValue("ID_Anggota", Orang.getIDOrang());
                query1.Parameters.AddWithValue("Nama_Anggota", Orang.getName());
                query1.Parameters.AddWithValue("NO_TELP", Orang.getNO_TELP());
                query1.Parameters.AddWithValue("Tanggal_Lahir", Orang.getTanggalLahir());
                query1.Parameters.AddWithValue("Email", Orang.getEmail());
                query1.Parameters.AddWithValue("Status_kerja", Orang.getStatus());
                query1.Parameters.AddWithValue("Saldo", Orang.getSaldo());
                query1.Parameters.AddWithValue("Username", Orang.getUsername());
                query1.Parameters.AddWithValue("Password", Orang.getPassword());
                query1.Parameters.AddWithValue("Id_role", Orang.getId_Role());
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

        public bool UpdateOrang(Orang Orang, string Username = "", string Password = "", string Status = "")
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                if (string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && string.IsNullOrEmpty(Status))
                {
                    using var query1 = new NpgsqlCommand(
                        "Update anggota_perusahaan set password=@Password where id_anggota = @ID_Anggota ", conn);
                    query1.Parameters.AddWithValue("Password", Password);
                    query1.Parameters.AddWithValue("ID_Anggota", Orang.getIDOrang());
                    int DampakBaris = query1.ExecuteNonQuery();
                    if (DampakBaris > 0)
                    {
                        isSucces = true;
                    }
                }
                else if (!string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password) && string.IsNullOrEmpty(Status))
                {
                    using var query1 = new NpgsqlCommand(
                        "Update anggota_perusahaan set username=@Username where id_anggota = @ID_Anggota ", conn);
                    query1.Parameters.AddWithValue("Username", Username);
                    query1.Parameters.AddWithValue("ID_Anggota", Orang.getIDOrang());
                    int DampakBaris = query1.ExecuteNonQuery();
                    if (DampakBaris > 0)
                    {
                        isSucces = true;
                    }
                }
                else if (string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Status))
                {
                    using var query1 = new NpgsqlCommand(
                        "Update anggota_perusahaan set status_kerja=@Status where id_anggota = @ID_Anggota ", conn);
                    query1.Parameters.AddWithValue("Status", Status);
                    query1.Parameters.AddWithValue("ID_Anggota", Orang.getIDOrang());
                    int DampakBaris = query1.ExecuteNonQuery();
                    if (DampakBaris > 0)
                    {
                        isSucces = true;
                    }
                }
                else
                {
                    using var query1 = new NpgsqlCommand(
                        "Update anggota_perusahaan set nama_anggota=@Nama_Anggota, no_telp=@NO_TELP, tanggal_lahir=@Tanggal_Lahir, email=@Email, status_kerja=@Status_kerja, saldo=@Saldo, id_role=@Id_role where id_anggota = @ID_Anggota", conn);
                    query1.Parameters.AddWithValue("ID_Anggota", Orang.getIDOrang());
                    query1.Parameters.AddWithValue("Nama_Anggota", Orang.getName());
                    query1.Parameters.AddWithValue("NO_TELP", Orang.getNO_TELP());
                    query1.Parameters.AddWithValue("Tanggal_Lahir", Orang.getTanggalLahir());
                    query1.Parameters.AddWithValue("Email", Orang.getEmail());
                    query1.Parameters.AddWithValue("Status_kerja", Orang.getStatus());
                    query1.Parameters.AddWithValue("Saldo", Orang.getSaldo());
                    query1.Parameters.AddWithValue("Id_role", Orang.getId_Role());
                    int DampakBaris = query1.ExecuteNonQuery();
                    if (DampakBaris > 0)
                    {
                        isSucces = true;
                    }
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

        public bool DelateOrang(int id)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("DELETE FROM Anggota_Perusahaan WHERE id=@id", conn);
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


        public bool UpdateSaldo (int id, decimal nominal)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("UPDATE Anggota_Perusahaan SET saldo = @saldo WHERE id=@id", conn);
                query1.Parameters.AddWithValue("id", id);
                query1.Parameters.AddWithValue("saldo", nominal);
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    isSucces = true;
                }
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Database: " + ex.Message, "Gagal update", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select no_telp from anggota_perusahaan where no_telp ilike @notelp", conn);
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
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select email from anggota_perusahaan where email ilike @email", conn);
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

        public bool? ApakahAdaUsername(string nama)
        {
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select username from anggota_perusahaan where username ilike @nama", conn);
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

        public int GetIdAnggota(string username, string password)
        {
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                string sql = "SELECT id_anggota FROM anggota_perusahaan WHERE username = @username AND password = @password";

                using var query1 = new NpgsqlCommand(sql, conn);
                query1.Parameters.AddWithValue("username", username);
                query1.Parameters.AddWithValue("password", password);

                using var reader = query1.ExecuteReader();
                if (reader.Read())
                {
                    return Convert.ToInt32(reader["id_anggota"]);
                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal autentikasi ke database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem login: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 0;
        }
    }
}
