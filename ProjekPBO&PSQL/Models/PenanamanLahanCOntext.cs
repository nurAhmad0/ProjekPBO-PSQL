using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    internal class PenanamanLahanCOntext
    {
        public List<PenanamanLahan> GETALLPenanamanLahan()
        {
            {
            List<PenanamanLahan> DataPenanaman = new List<PenanamanLahan>();
                try
                {
                    using var conn = DataBaseHelper.GetConnection();
                    conn.Open();
                    using var query1 = new NpgsqlCommand("SELECT pl.id_penanaman,pl.tanggal_ditanam,pl.jumlah_tanaman,pl.status_penanaman,l.id_lahan,l.nama_lahan,l.luas_lahan,t.id_tanaman,t.nama_tanaman,t.harga FROM Penanaman_Lahan pl INNER JOIN Lahan l ON pl.id_lahan = l.id_lahan INNER JOIN Tanaman t ON pl.id_tanaman = t.id_tanaman ORDER BY pl.tanggal_ditanam DESC;", conn);
                    using var reader = query1.ExecuteReader();
                    while (reader.Read())
                    {
                        DataPenanaman.Add(new PenanamanLahan(
                            reader.GetInt32(0),                                                
                            reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1),         
                            reader.IsDBNull(2) ? 0 : reader.GetInt32(2),                        
                            reader.IsDBNull(3) ? "-" : reader.GetString(3),                    
                            reader.IsDBNull(4) ? 0 : reader.GetInt32(4),                      
                            reader.IsDBNull(5) ? "-" : reader.GetString(5),                     
                            reader.IsDBNull(6) ? 0 : (decimal)reader.GetDouble(6),        
                            reader.IsDBNull(7) ? "-" : reader.GetString(7),                  
                            reader.IsDBNull(8) ? 0 : reader.GetInt32(8),                        
                            reader.IsDBNull(9) ? "-" : reader.GetString(9),                    
                            reader.IsDBNull(10) ? 0 : Convert.ToInt32(reader.GetDecimal(10)),   
                            reader.IsDBNull(11) ? 0 : reader.GetInt32(11)                      
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

                return DataPenanaman;
            }
        }

        public bool ADDPenanamanLahan(PenanamanLahan penanaman)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "INSERT INTO Penanaman_Lahan (tanggal_ditanam, jumlah_tanaman, status_penanaman, id_lahan, id_tanaman) VALUES (@tanggalDitanam, @JumlahTanaman, @StatusPenananam, @idLahan, @idTanaman)", conn);
                query1.Parameters.AddWithValue("tanggalDitanam", penanaman.getTanggalDitanam());
                query1.Parameters.AddWithValue("JumlahTanaman", penanaman.getJumlahTanaman());
                query1.Parameters.AddWithValue("StatusPenanaman", penanaman.getStatusPenanaman());
                query1.Parameters.AddWithValue("idLahan", penanaman.getLahanTempatMenanam().getIdLahan());
                query1.Parameters.AddWithValue("idTanaman", penanaman.getJenisTanaman().getIdTanaman());
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    isSucces = true;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal menambahkan data ke database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSucces;
        }


        public bool DELETEPenanamanLahan(int id)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("DELETE FROM Penanaman_lahan WHERE id=@id", conn);
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
    }
}
