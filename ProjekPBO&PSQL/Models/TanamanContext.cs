using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ProjekPBO_PSQL.Controllers;

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
                        reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
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
                    "INSERT INTO Tanaman (nama_tanaman, harga, estimasi_kadaluarsa) VALUES (@Nama_Tanaman, @Harga, @Estimasi_Kadaluarsa)", conn);
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
                    "update Tanaman set Nama_Tanaman=@Nama_Tanaman, harga=@Harga, estimasi_kadaluarsa=@Estimasi_Kadaluarsa where ID_Tanaman=@ID_Tanaman", conn);
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

        public DataTable getALLHistoriHarga()
        {

            DataTable dataHistoriHarga = new DataTable();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT id_histori,id_tanaman, harga_lama, Harga_baru, tanggal_perubahan from histori_harga_tanaman;", conn);
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(dataHistoriHarga);
                    }
                }
                return dataHistoriHarga;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataHistoriHarga;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataHistoriHarga;
            }
        }


        public DataTable getJumlahTanamanBerdasarkanBulan()
        {

            DataTable dataTanamanBulan = new DataTable();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT od.harga AS Dimensi_Harga, od.jumlah_produk AS Dimensi_Jumlah_Terjual, t.nama_tanaman AS Nama Tanaman, SUM(od.jumlah_produk) AS 'Akumulasi Tanaman Terjual' FROM order_details od INNER JOIN \"order\" o ON od.id_order = o.id_order INNER JOIN Tanaman t ON od.id_tanaman = t.id_tanaman GROUP BY CUBE (od.harga, od.jumlah_produk, t.nama_tanaman);", conn);
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(dataTanamanBulan);
                    }
                }
                return dataTanamanBulan;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTanamanBulan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTanamanBulan;
            }
        }

        public DataTable get10TanamanPalingBanyakDibeli()
        {
            DataTable data10Tanaman = new DataTable();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT id_tanaman, nama_tanaman, harga FROM Tanaman WHERE id_tanaman IN (SELECT id_tanaman FROM order_details GROUP BY id_tanaman ORDER BY max(jumlah_produk) DESC LIMIT 10);", conn);
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(data10Tanaman);
                    }
                }
                return data10Tanaman;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data10Tanaman;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data10Tanaman;
            }
        }

        public DataTable getTanamanYangBelumTerjual()
        {
            DataTable dataTanamanBelumterjual = new DataTable();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT id_tanaman, nama_tanaman FROM Tanaman EXCEPT SELECT od.id_tanaman, t.nama_tanaman FROM order_details od JOIN Tanaman t ON od.id_tanaman = t.id_tanaman;", conn);
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(dataTanamanBelumterjual);
                    }
                }
                return dataTanamanBelumterjual;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTanamanBelumterjual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTanamanBelumterjual;
            }
        }

        public int HitungUsiaTanaman(int idLahan, int idTanaman)
        {
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT hitung_usia_tanaman(@idLahan, @idTanaman);", conn);
                query1.Parameters.AddWithValue("idLahan", idLahan);
                query1.Parameters.AddWithValue("idTanaman", idTanaman);
                var result = query1.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                return 0;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;

            }
        }

        public bool? ApakahAdaNamaTanaman(string nama)
        {
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("Select nama_tanaman from tanaman where nama_tanaman ilike @nama", conn);
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

