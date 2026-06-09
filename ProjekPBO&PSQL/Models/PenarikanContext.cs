using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class PenarikanContext
    {
        public DataTable GetAllDataPenarikan()
        {
            DataTable dataPenarikan = new DataTable();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT rp.id_riwayat_penarikan, rp.tanggal_penarikan, rp.metode_penarikan, rp.nominal, rp.status_pencairan, ap.nama_anggota FROM riwayat_penarikan rp join anggota_perusahaan ap ON rp.id_anggota = ap.id_anggota order by rp.status_pencairan", conn);
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(dataPenarikan);
                    }
                }
                return dataPenarikan;

            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Database: " + ex.Message, "Gagal Menarik", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return dataPenarikan;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Sistem: " + ex.Message, "Gagal", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return dataPenarikan;
            }
        }

        public bool TambahRiwayatPenarikan(decimal nominal, string metodePenarikan, int idAnggota)
        {
            bool isSucces = false;
            try
            {
                DateTime TanggalSekarang = DateTime.Now;
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                if (metodePenarikan == "Transfer")
                {
                    using var query1 = new NpgsqlCommand("INSERT INTO riwayat_penarikan (tanggal_penarikan, metode_penarikan, nominal, status_pencairan, id_anggota) VALUES (@Tanggal_Sekarang, @Metode_Penarikan, @nominal, @Status_Pencairan, @IdAnggota)", conn);
                    query1.Parameters.AddWithValue("Tanggal_Sekarang", TanggalSekarang);
                    query1.Parameters.AddWithValue("Metode_Penarikan", NpgsqlTypes.NpgsqlDbType.Unknown, "Transfer");
                    query1.Parameters.AddWithValue("nominal", nominal);
                    query1.Parameters.AddWithValue("Status_Pencairan", NpgsqlTypes.NpgsqlDbType.Unknown, "Selesai");
                    query1.Parameters.AddWithValue("IdAnggota", idAnggota);
                    int DampakBaris = query1.ExecuteNonQuery();
                    if (DampakBaris > 0)
                    {
                        isSucces = true;
                    }
                }
                else
                {
                    using var query1 = new NpgsqlCommand("INSERT INTO riwayat_penarikan (tanggal_penarikan, metode_penarikan, nominal, status_pencairan, id_anggota) VALUES (@Tanggal_Sekarang, @Metode_Penarikan, @nominal, @Status_Pencairan, @IdAnggota)", conn);
                    query1.Parameters.AddWithValue("Tanggal_Sekarang", TanggalSekarang);
                    query1.Parameters.AddWithValue("Metode_Penarikan", NpgsqlTypes.NpgsqlDbType.Unknown, "Cash");
                    query1.Parameters.AddWithValue("nominal", nominal);
                    query1.Parameters.AddWithValue("Status_Pencairan", NpgsqlTypes.NpgsqlDbType.Unknown, "Pending");
                    query1.Parameters.AddWithValue("IdAnggota", idAnggota);
                    int DampakBaris = query1.ExecuteNonQuery();
                    if (DampakBaris > 0)
                    {
                        isSucces = true;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Database: " + ex.Message, "Gagal Menambahkan", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isSucces = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eror Sistem: " + ex.Message, "Gagal", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                isSucces = false;
            }
            return isSucces;
        }

        public bool UpdateStatusRiwayat(int idPenarikan)
        {
            bool isSucces = false;
            try
            {
                DateTime TanggalSekarang = DateTime.Now;
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("UPDATE riwayat_penarikan SET status_pencairan = 'Selesai' where id_riwayat_penarikan = @IDPenarikan", conn);
                query1.Parameters.AddWithValue("IDPenarikan", idPenarikan);
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
    }
}
