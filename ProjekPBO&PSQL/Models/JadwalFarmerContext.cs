using System;
using System.Collections.Generic;
using System.Text;
using ProjekPBO_PSQL.Helpers;
using Npgsql;

namespace ProjekPBO_PSQL.Models
{
    class JadwalFarmerContext
    {
        public List<Jadwal> GetALLJadwal()
        {
            List<JadwalFarmer> DataJadwalFarmer = new List<JadwalFarmer>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "SELECT id_jadwal, tanggal, keterangan_kegiatan, banyaknya_anggota, id_farmer, nama_farmer, status_pekerjaan, nama_lahan, nama_tanaman, tanggal_ditanam, jumlah_tanaman FROM view_jadwal_farmer;", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataJadwalFarmer.Add(new JadwalFarmer(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1),
                        reader.IsDBNull(2) ? "-" : reader.GetString(2),
                        reader.IsDBNull(3) ? "Tidak Ada Tipe Jadwal" : reader.GetString(3),
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

            return DataJadwalFarmer;
        }

    }
}
