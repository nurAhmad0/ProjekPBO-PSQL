using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class RiwayatPenarikancontext
    {
        public DataTable getALLDataPenarikan(int idAnggota)
        {

            DataTable dataPenarikan = new DataTable();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT r.id_riwayat_penarikan AS ID, r.tanggal_penarikan AS Tanggal, r.metode_penarikan AS Metode, a.nama_anggota AS 'Nama Anggota' FROM riwayat_penarikan r INNER JOIN anggota_perusahaan a ON r.id_anggota = a.id_anggota where r.id_anggota = @idAnggota ORDER BY r.tanggal_penarikan DESC;", conn);
                query1.Parameters.AddWithValue("idAnggota", idAnggota);
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
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataPenarikan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataPenarikan;
            }
        } 
    }
}
