using System;
using System.Collections.Generic;
using System.Text;
using ProjekPBO_PSQL.Helpers;
using Npgsql;

namespace ProjekPBO_PSQL.Models
{
    class JadwalFarmerContext
    {

        public List<JadwalFarmer> GetALLJadwalFarmer()
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
                    int idJadwalCur = reader.GetInt32(0);

                    JadwalFarmer? jadwalEksis = null;
                    foreach (JadwalFarmer j in DataJadwalFarmer)
                    {
                        if (j.getIdJadwal() == idJadwalCur )
                        {
                            jadwalEksis = j;
                            break;
                        }
                    }

                    if (jadwalEksis == null)
                    {
                        DateTime tanggal = reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1);
                        string keterangan = reader.IsDBNull(2) ? "-" : reader.GetString(2);
                        int banyakAnggota = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        string status = reader.IsDBNull(6) ? "Belum Dikerjakan" : reader.GetString(6);
                        string namaLahan = reader.IsDBNull(7) ? "-" : reader.GetString(7);
                        string namaTanaman = reader.IsDBNull(8) ? "-" : reader.GetString(8);
                        DateTime tglDitanam = reader.IsDBNull(9) ? DateTime.Now : reader.GetDateTime(9);
                        int jmlDitanam = reader.IsDBNull(10) ? 0 : reader.GetInt32(10);

                        jadwalEksis = new JadwalFarmer(
                            idJadwalCur,
                            tanggal,
                            keterangan,
                            banyakAnggota,
                            new List<int>(),    
                            new List<string>(), 
                            status,
                            namaLahan,
                            namaTanaman,
                            tglDitanam,
                            jmlDitanam
                        );


                        DataJadwalFarmer.Add(jadwalEksis);
                    }

                    if (!reader.IsDBNull(4))
                    {
                        int idPetani = reader.GetInt32(4);
                        string namaPetani = reader.GetString(5);

                        jadwalEksis.getIDAnggota().Add(idPetani);
                        jadwalEksis.getNamaAnggota().Add(namaPetani);
                    }
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
