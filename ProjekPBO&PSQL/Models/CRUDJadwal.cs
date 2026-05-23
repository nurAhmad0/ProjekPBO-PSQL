//using Npgsql;
//using ProjekPBO_PSQL.Helpers;
//using System;
//using System.Collections.Generic;
//using System.Net.NetworkInformation;
//using System.Text;

//namespace ProjekPBO_PSQL.Models
//{
//    class CRUDJadwal
//    {
//        public List<Jadwal> GetALLJadwal()
//        {
//            List<Jadwal> DataJadwal = new List<Jadwal>();
//            try
//            {
//                using var conn = DataBaseHelper.GetConnection();
//                conn.Open();
//                using var query1 = new NpgsqlCommand(
//                    "select ID_Jadwal, Tanggal, Keterangan_Kegiatan, Tipe_Jadwal, Banyak_Anggota from jadwal", conn);
//                using var reader = query1.ExecuteReader();
//                while (reader.Read())
//                {
//                    DataJadwal.Add(new Jadwal(
//                        reader.GetInt32(0),
//                        reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1),
//                        reader.IsDBNull(2) ? "-" : reader.GetString(2),
//                        reader.IsDBNull(3) ? "Tidak Ada Tipe Jadwal" : reader.GetString(3),
//                        reader.IsDBNull(4) ? 0 : reader.GetInt32(4)
//                        ));
//                }
//            }  
//            catch (NpgsqlException ex)
//            {
//                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            catch (Exception ex)
//            {
                
//                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }

//            return DataJadwal;
//        }

//        public void ADDJadwal(Jadwal jadwal)
//        {
//            using var conn = DataBaseHelper.GetConnection();
//            conn.Open();
//            using var query1 = new NpgsqlCommand(
//                "Insert into Jadwal (ID_Jadwal, Tanggal, Keterangan_Kegiatan, Tipe_Jadwal, Banyak_Anggota) values (@ID_Jadwal, @Tanggal, @Keterangan_Kegiatan, @Tipe_Jadwal, @Banyak_Anggota)", conn);
//            query1.Parameters.AddWithValue("ID_Jadwal", jadwal.getIdJadwal());
//            query1.Parameters.AddWithValue("Tanggal", jadwal.getTanggal());
//            query1.Parameters.AddWithValue("Keteranggan_Kegiatan", jadwal.getKeteranganKegiatan());
//            query1.Parameters.AddWithValue("Tipe_Jadwal", jadwal.getTipeJadwal());
//            query1.Parameters.AddWithValue("Banyak_Anggota", jadwal.getBanyakAnggota());
//            query1.ExecuteNonQuery();
//        }

//        public void UPDATEJadwal(Jadwal jadwal)
//        {
//            using var conn = DataBaseHelper.GetConnection();
//            conn.Open();
//            using var query1 = new NpgsqlCommand(
//                "update Jadwal set ID_Jadwl=@ID_Jadwal, Tanggal=@Tanggal, Keterangan_Kegiatan=@Keterangan_Kegiatan, Tipe_Jadwal=@Tipe_Jadwal, Banyak_Anggota=@Banyak_Anggota", conn);
//            query1.Parameters.AddWithValue("ID_Jadwal", jadwal.getIdJadwal());
//            query1.Parameters.AddWithValue("Tanggal", jadwal.getTanggal());
//            query1.Parameters.AddWithValue("Keteranggan_Kegiatan", jadwal.getKeteranganKegiatan());
//            query1.Parameters.AddWithValue("Tipe_Jadwal", jadwal.getTipeJadwal());
//            query1.Parameters.AddWithValue("Banyak_Anggota", jadwal.getBanyakAnggota());
//            query1.ExecuteNonQuery();
//        }

//        public void DELATEJadwal(int id)
//        {
//            using var conn = DataBaseHelper.GetConnection();
//            conn.Open();
//            using var cmd = new NpgsqlCommand("DELETE FROM Jadwal WHERE ID_Jadwal=@id", conn);
//            cmd.Parameters.AddWithValue("id", id);
//            cmd.ExecuteNonQuery();
//        }
//    }
//}
