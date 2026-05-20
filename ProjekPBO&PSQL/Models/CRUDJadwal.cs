using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class CRUDJadwal
    {
        public List<Jadwal> GetALLJadwal()
        {
            List<Jadwal> DataJadwal = new List<Jadwal>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "select ID_Jadwal, Tanggal, Keterangan_Kegiatan, Tipe_Jadwal, Banyak_Anggota from jadwal", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataJadwal.Add(new Jadwal(
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

            return DataJadwal;
        }

        public void ADDJadwal(Jadwal jadwal)
        {
            using var conn = DataBaseHelper.GetConnection();
            conn.Open();
            using var query1 = new NpgsqlCommand(
                "Insert into Jadwal (ID_Jadwal, Tanggal, Keterangan_Kegiatan, Tipe_Jadwal, Banyak_Anggota) values (ID_Jadwal=@ID_Jadwal, Tanggal=@Tanggal, Keterangan_Kegiatan=@Keterangan_Kegiatan, Tipe_Jadwal=@Tipe_Jadwal, Banyak_Anggota=@Banyak_Anggota)", conn);
            query1.Parameters.AddWithValue("ID_Jadwalanggan.getIdPelanggan());
            query1.Parameters.AddWithValue("Nama_Pelanggan", pelanggan.getNamePelanggan());
            query1.Parameters.AddWithValue("NO_TELP", pelanggan.getNO_TELP());
            query1.Parameters.AddWithValue("Email", pelanggan.getEmail());
            query1.Parameters.AddWithValue("Detail_Alamat", pelanggan.getDetailAlamat());
            query1.ExecuteNonQuery();
        }
    }
}
