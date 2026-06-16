using Npgsql;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class LaporanContext
    {
        public List<Laporan> getAllLaporan()
        {
            List<Laporan> DataLaporan = new List<Laporan>();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT l.id_laporan, l.isi_laporan, l.waktu_lapor, l.id_jadwal, l.id_anggota, j.keterangan_kegiatan, ap.nama_anggota, j.tanggal AS tanggal_jadwal FROM laporan_jadwal l INNER JOIN jadwal j ON l.id_jadwal = j.id_jadwal INNER JOIN anggota_perusahaan ap ON l.id_anggota = ap.id_anggota order by l.waktu_lapor desc;", conn);
                using var reader = query1.ExecuteReader();
                while (reader.Read())
                {
                    DataLaporan.Add(new Laporan(
                        reader.GetInt32(0),
                        reader.IsDBNull(1) ? "Laporan Tidak Ada Isi" : reader.GetString(1),
                        reader.IsDBNull(2) ? DateTime.Now : reader.GetDateTime(2),
                        reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                        reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                        reader.IsDBNull(5) ? "Tidak Ada Keterangan Jadwal" : reader.GetString(5),
                        reader.IsDBNull(6) ? "Tidak Ada Nama Anggota" : reader.GetString(6),
                        reader.IsDBNull(7) ? DateTime.Now : reader.GetDateTime(7)
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

            return DataLaporan;
        }

        public bool ADDLaporan(Laporan Laporan)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "INSERT INTO laporan_jadwal (isi_laporan, id_jadwal, id_anggota) VALUES (@Isi_laporan, @Id_jadwal, @Id_anggota)", conn);
                query1.Parameters.AddWithValue("Isi_laporan", Laporan.getIsiLaporan());
                query1.Parameters.AddWithValue("Id_jadwal", Laporan.getidJadwal());
                query1.Parameters.AddWithValue("Id_anggota", Laporan.getIdAnggota());
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

        public bool UpdateLaporan(Laporan Laporan)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "update laporan_jadwal set isi_laporan=@Isi_laporan where id_laporan = @IDLaporan", conn);
                query1.Parameters.AddWithValue("Isi_laporan", Laporan.getIsiLaporan());
                query1.Parameters.AddWithValue("IDLaporan", Laporan.getIdlaporan());
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

        public bool DelateLaporan(int id)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("DELETE FROM Laporan WHERE id=@id", conn);
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
