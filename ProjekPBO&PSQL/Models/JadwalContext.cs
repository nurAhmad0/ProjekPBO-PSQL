using Npgsql;
using ProjekPBO_PSQL.Controllers;
using ProjekPBO_PSQL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class JadwalContext
    {
        public JadwalPengantaran? GetALLJadwalPengataran(int idJadwal)
        {
            JadwalPengantaran? jadwalHasil = null;

            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "SELECT id_jadwal, tanggal, keterangan_kegiatan, banyaknya_anggota, status_global, id_pengantar, nama_pengantar, waktu_join, nama_pelanggan, no_telp_pelanggan, alamat_tujuan, id_order, tanggal_order, jumlah_produk, harga_produk, nama_tanaman, id_pelanggan, total_upah, upah_diterima, id_tanaman, id_order_details FROM view_jadwal_pengantar where id_jadwal = @id;", conn);
                query1.Parameters.AddWithValue("id", idJadwal);
                using var reader = query1.ExecuteReader();

                while (reader.Read())
                {
                    if (jadwalHasil == null)
                    {
                        int idJadwalCur = reader.GetInt32(0);
                        DateTime tanggal = reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1);
                        string keterangan = reader.IsDBNull(2) ? "-" : reader.GetString(2);
                        int banyakAnggota = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        string status = reader.IsDBNull(4) ? "Belum Dikerjakan" : reader.GetString(4);
                        string namaPelanggan = reader.IsDBNull(8) ? "-" : reader.GetString(8);
                        string noTelpPelanggan = reader.IsDBNull(9) ? "-" : reader.GetString(9);
                        string alamatTujuan = reader.IsDBNull(10) ? "Detail Alamat Tidak Ada" : reader.GetString(10);
                        int idOrder = reader.IsDBNull(11) ? 0 : reader.GetInt32(11);
                        DateTime tglOrder = reader.IsDBNull(12) ? DateTime.Now : reader.GetDateTime(12);
                        int idPelanggan = reader.IsDBNull(16) ? 0 : reader.GetInt32(16);
                        decimal totalUpah = reader.IsDBNull(17) ? 0 : reader.GetDecimal(17);

                        Order orderBaru = new Order(idOrder, tglOrder, 0, idPelanggan);

                        jadwalHasil = new JadwalPengantaran(
                            idJadwalCur,
                            tanggal,
                            keterangan,
                            banyakAnggota,
                            status,
                            namaPelanggan,
                            noTelpPelanggan,
                            alamatTujuan,
                            idPelanggan,
                            totalUpah,
                            orderBaru
                        );
                    }
                    if (!reader.IsDBNull(11))
                    {
                        int idOrder = reader.GetInt32(11);
                        decimal jmlProduk = reader.IsDBNull(13) ? 0 : Convert.ToDecimal(reader.GetValue(13));
                        decimal hargaProduk = reader.IsDBNull(14) ? 0 : Convert.ToDecimal(reader.GetValue(14));
                        int idTanaman = reader.IsDBNull(19) ? 0 : reader.GetInt32(19);
                        int idOrderDetails = reader.IsDBNull(20) ? 0 : reader.GetInt32(20);
                        string namaTanaman = reader.IsDBNull(15) ? "-" : reader.GetString(15);
                        if (!jadwalHasil.getOrderData().getlistOrderdetails().Any(od => od.getIDOrderDetails() == idOrderDetails && idOrderDetails != 0))
                        {
                            OrderDetails detailProduk = new OrderDetails(idOrderDetails, hargaProduk, jmlProduk, idOrder, idTanaman, namaTanaman);
                            jadwalHasil.getOrderData().getlistOrderdetails().Add(detailProduk);
                        }
                    }
                    if (!reader.IsDBNull(5))
                    {
                        int idPengantar = reader.GetInt32(5);
                        string namaPengantar = reader.GetString(6);
                        DateTime waktuMulaiJoin = reader.IsDBNull(7) ? DateTime.Now : reader.GetDateTime(7);
                        decimal upahDiterima = reader.IsDBNull(18) ? 0 : reader.GetDecimal(18);
                        DetailAnggotaJadwal anggotaBaru = new DetailAnggotaJadwal(idPengantar, namaPengantar, waktuMulaiJoin, upahDiterima);
                        if (!jadwalHasil.getDaftarAnggota().Any(a => a.getIdAnggota() == idPengantar))
                        {
                            jadwalHasil.getDaftarAnggota().Add(anggotaBaru);
                        }
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

            return jadwalHasil;
        }

        public JadwalFarmer? GetALLJadwalFarmer(int idJadwal)
        {
            JadwalFarmer? jadwalHasil = null;

            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "SELECT id_jadwal, tanggal, keterangan_kegiatan, banyaknya_anggota, status_global, id_farmer, nama_farmer, waktu_join, nama_lahan, nama_tanaman, tanggal_ditanam, jumlah_tanaman, id_lahan, total_upah, upah_diterima FROM view_jadwal_farmer where id_jadwal = @id;", conn);
                query1.Parameters.AddWithValue("id", idJadwal);
                using var reader = query1.ExecuteReader();

                while (reader.Read())
                {
                    // Karena ini berdasarkan ID unik, kita hanya perlu menginstansiasi objek JadwalFarmer sekali saja di baris pertama loop
                    if (jadwalHasil == null)
                    {
                        int idJadwalCur = reader.GetInt32(0);
                        DateTime tanggal = reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1);
                        string keterangan = reader.IsDBNull(2) ? "-" : reader.GetString(2);
                        int banyakAnggota = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        string status = reader.IsDBNull(4) ? "Belum Dikerjakan" : reader.GetString(4);
                        string namaLahan = reader.IsDBNull(8) ? "-" : reader.GetString(8);
                        string namaTanaman = reader.IsDBNull(9) ? "-" : reader.GetString(9);
                        DateTime tglDitanam = reader.IsDBNull(10) ? DateTime.Now : reader.GetDateTime(10);
                        int jmlDitanam = reader.IsDBNull(11) ? 0 : reader.GetInt32(11);
                        int idLahan = reader.IsDBNull(12) ? 0 : reader.GetInt32(12);
                        decimal totalUpah = reader.IsDBNull(13) ? 0 : reader.GetDecimal(13);

                        jadwalHasil = new JadwalFarmer(
                            idJadwalCur,
                            tanggal,
                            keterangan,
                            banyakAnggota,
                            status,
                            namaLahan,
                            namaTanaman,
                            tglDitanam,
                            jmlDitanam,
                            idLahan,
                            totalUpah
                        );
                    }

                    // Loop ke bawahnya bertugas untuk mengumpulkan daftar anggota petani jika data barisnya lebih dari satu (relasi join banyak anggota)
                    if (!reader.IsDBNull(5))
                    {
                        int idPetani = reader.GetInt32(5);
                        string namaPetani = reader.GetString(6);
                        DateTime waktuMulaiJoin = reader.IsDBNull(7) ? DateTime.Now : reader.GetDateTime(7);
                        decimal upahDiterima = reader.IsDBNull(14) ? 0 : reader.GetDecimal(14);

                        DetailAnggotaJadwal anggotaBaru = new DetailAnggotaJadwal(idPetani, namaPetani, waktuMulaiJoin, upahDiterima);

                        if (!jadwalHasil.getDaftarAnggota().Any(a => a.getIdAnggota() == idPetani))
                        {
                            jadwalHasil.getDaftarAnggota().Add(anggotaBaru);
                        }
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

            return jadwalHasil;
        }

        public DataTable getjadwalFarmer()
        {
            DataTable dataJadwalFarmer = new DataTable();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT id_jadwal, tanggal, keterangan_kegiatan, text_tipe_jadwal, banyaknya_anggota, total_upah, status_global FROM jadwal where text_tipe_jadwal = 'Farmer'", conn);
                
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(dataJadwalFarmer);
                    }
                }
                return dataJadwalFarmer;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataJadwalFarmer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataJadwalFarmer;
            }
        }

        public DataTable getJadwalPengantaran()
        {
            DataTable dataJadwalPengantar = new DataTable();
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT id_jadwal, tanggal, keterangan_kegiatan, text_tipe_jadwal, banyaknya_anggota, total_upah, status_global FROM jadwal where text_tipe_jadwal = 'Pengantar'", conn);
                
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(dataJadwalPengantar);
                    }
                }
                return dataJadwalPengantar;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataJadwalPengantar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataJadwalPengantar;
            }
        }

        public DataTable getjadwalFarmerHariIni()
        {
            DataTable dataJadwalFarmer = new DataTable();
            try
            {
                DateTime TanggalSekarang = DateTime.Today;
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT id_jadwal, tanggal, keterangan_kegiatan, text_tipe_jadwal, banyaknya_anggota, total_upah, status_global FROM jadwal where text_tipe_jadwal = 'Farmer' and tanggal = @tanggal", conn);
                query1.Parameters.AddWithValue("tanggal", TanggalSekarang);
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(dataJadwalFarmer);
                    }
                }
                return dataJadwalFarmer;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataJadwalFarmer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataJadwalFarmer;
            }
        }

        public DataTable getJadwalPengantaranHariIni()
        {
            DataTable dataJadwalPengantar = new DataTable();
            try
            {
                DateTime TanggalSekarang = DateTime.Today;
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand("SELECT id_jadwal, tanggal, keterangan_kegiatan, text_tipe_jadwal, banyaknya_anggota, total_upah, status_global FROM jadwal where text_tipe_jadwal = 'Pengantar' and tanggal = @tanggal", conn);
                query1.Parameters.AddWithValue("tanggal", TanggalSekarang);
                {
                    using (var da = new NpgsqlDataAdapter(query1))
                    {
                        da.Fill(dataJadwalPengantar);
                    }
                }
                return dataJadwalPengantar;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal mengambil data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataJadwalPengantar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataJadwalPengantar;
            }
        }

        //public bool UPDATEJadwal(Jadwal jadwal, int idAnggota = 0, string Status = "")
        //{
        //    bool isSucces = false;
        //    try
        //    {
        //        using var conn = DataBaseHelper.GetConnection();
        //        conn.Open();
        //        if (!string.IsNullOrEmpty(Status) && idAnggota > 0)
        //        {
        //            using var query1 = new NpgsqlCommand(
        //                "update Detail_Jadwal set status = @status where id_jadwal = @id_jadwal and id_anggota = @id_anggota", conn);
        //            query1.Parameters.AddWithValue("status", Status);
        //            query1.Parameters.AddWithValue("id_anggota", idAnggota);
        //            query1.Parameters.AddWithValue("id_jadwal", jadwal.getIdJadwal());
        //            int DampakBaris = query1.ExecuteNonQuery();
        //            if (DampakBaris > 0)
        //            {
        //                isSucces = true;
        //            }
        //        }
        //        else if (!string.IsNullOrEmpty(Status) && idAnggota == 0)
        //        {
        //            var daftar = jadwal.getDaftarAnggota();

        //            if (daftar != null && daftar.Count > 0)
        //            {
                        
        //                foreach (DetailAnggotaJadwal anggota in daftar)
        //                {
        //                    using var query1 = new NpgsqlCommand(
        //                        "update Detail_Jadwal set status = @status where id_jadwal = @id_jadwal", conn);

        //                    query1.Parameters.AddWithValue("status", Status); 
        //                    query1.Parameters.AddWithValue("id_jadwal", jadwal.getIdJadwal());

        //                    int DampakBaris = query1.ExecuteNonQuery();
        //                    if (DampakBaris > 0)
        //                    {
        //                        isSucces = true;
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            using var query1 = new NpgsqlCommand(
        //                "update jadwal set tanggal=@Tanggal, keterangan_kegiatan=@keteranganKegiatan, text_tipe_jadwal=@tipeJadwal, banyaknya_anggota=@banyakAnggota, status_global=@status, id_lahan=@idLahan, id_pelanggan=@idPelanggan where id_jadwal=@id_jadwal", conn);
        //            query1.Parameters.AddWithValue("id_jadwal", jadwal.getIdJadwal());
        //            query1.Parameters.AddWithValue("Tanggal", jadwal.getTanggal());
        //            query1.Parameters.AddWithValue("keteranganKegiatan", jadwal.getKeteranganKegiatan());
        //            query1.Parameters.AddWithValue("tipeJadwal", jadwal.getTipeJadwal());
        //            query1.Parameters.AddWithValue("banyakAnggota", jadwal.getBanyakAnggota());
        //            query1.Parameters.AddWithValue("status", jadwal.getStatus());
        //            if(jadwal is JadwalFarmer farmer)
        //            {
        //                query1.Parameters.AddWithValue("idLahan", farmer.getIDLahan());
        //                query1.Parameters.AddWithValue("idPelanggan", DBNull.Value);
        //            }
        //            else if (jadwal is JadwalPengantaran pengantaran)
        //            {
        //                query1.Parameters.AddWithValue("idLahan", DBNull.Value);
        //                query1.Parameters.AddWithValue("idPelanggan", pengantaran.getIDPelanggan());
        //            }
        //            else
        //            {
        //                query1.Parameters.AddWithValue("idLahan", DBNull.Value);
        //                query1.Parameters.AddWithValue("idPelanggan", DBNull.Value);
        //            }
        //            int DampakBaris = query1.ExecuteNonQuery();
        //            if (DampakBaris > 0)
        //            {
        //                isSucces = true;
        //            }
        //        }
        //    }
        //    catch (NpgsqlException ex)
        //    {
        //        MessageBox.Show("Gagal Update data: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return isSucces;
        //}

        public bool ADDJadwal(Jadwal jadwal)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                        "insert into jadwal (tanggal, keterangan_kegiatan, text_tipe_jadwal, banyaknya_anggota, status_global, id_lahan, id_pelanggan) values (@Tanggal, @Keterangan, @TipeJadwal::tipe_jadwal, @BanyakAnggota, @Status, @IdLahan, @IdPelanggan)", conn);
                query1.Parameters.AddWithValue("Tanggal", jadwal.getTanggal());
                query1.Parameters.AddWithValue("keterangan", jadwal.getKeteranganKegiatan());
                query1.Parameters.AddWithValue("TipeJadwal", jadwal.getTipeJadwal());
                query1.Parameters.AddWithValue("BanyakAnggota", jadwal.getBanyakAnggota());
                query1.Parameters.AddWithValue("Status", jadwal.getStatus());
                if (jadwal is JadwalFarmer farmer)
                {
                    query1.Parameters.AddWithValue("IdLahan", farmer.getIDLahan());
                    query1.Parameters.AddWithValue("IdPelanggan", DBNull.Value);
                }
                else if (jadwal is JadwalPengantaran pengantaran)
                {
                    query1.Parameters.AddWithValue("IdLahan", DBNull.Value);
                    query1.Parameters.AddWithValue("IdPelanggan", pengantaran.getIDPelanggan());
                }
                else
                {
                    query1.Parameters.AddWithValue("IdLahan", DBNull.Value);
                    query1.Parameters.AddWithValue("IdPelanggan", DBNull.Value);
                }
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    isSucces = true;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal menambahkan data dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSucces;
        }

        public bool delateJadwal(int id)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "call hapus_jadwal(@id)", conn);
                query1.Parameters.AddWithValue("id", id);
                int DampakBaris = query1.ExecuteNonQuery();
                if (DampakBaris > 0)
                {
                    isSucces = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada kueri yang gagal, database gagal dihapus! Eror: " + ex.Message);
            }
            return isSucces;
        }

        public bool ADDDetailJadwal(int idAnggota, int idJadwal)
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                using var query1 = new NpgsqlCommand(
                    "INSERT INTO detail_jadwal (id_jadwal, id_anggota) VALUES (@id_jadwal, @id_anggota)", conn);
                query1.Parameters.AddWithValue("id_anggota", idAnggota);
                query1.Parameters.AddWithValue("id_jadwal", idJadwal);
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


        public bool UPDATEJadwal(Jadwal jadwal, string Status = "")
        {
            bool isSucces = false;
            try
            {
                using var conn = DataBaseHelper.GetConnection();
                conn.Open();
                
                if (!string.IsNullOrEmpty(Status))
                {
                    using var query1 = new NpgsqlCommand(
                        "update Jadwal set status_global = @status::status where id_jadwal = @id_jadwal", conn);

                    query1.Parameters.AddWithValue("status", Status);
                    query1.Parameters.AddWithValue("id_jadwal", jadwal.getIdJadwal());

                    int DampakBaris = query1.ExecuteNonQuery();
                    if (DampakBaris > 0)
                    {
                        isSucces = true;
                    }
                }
                else
                {
                    using var query1 = new NpgsqlCommand(
                        "update jadwal set tanggal=@Tanggal, keterangan_kegiatan=@keteranganKegiatan, text_tipe_jadwal=@tipeJadwal::tipe_jadwal, banyaknya_anggota=@banyakAnggota, status_global=@status::status, id_lahan=@idLahan, id_pelanggan=@idPelanggan where id_jadwal=@id_jadwal", conn);
                    query1.Parameters.AddWithValue("id_jadwal", jadwal.getIdJadwal());
                    query1.Parameters.AddWithValue("Tanggal", jadwal.getTanggal());
                    query1.Parameters.AddWithValue("keteranganKegiatan", jadwal.getKeteranganKegiatan());
                    query1.Parameters.AddWithValue("tipeJadwal", jadwal.getTipeJadwal());
                    query1.Parameters.AddWithValue("banyakAnggota", jadwal.getBanyakAnggota());
                    query1.Parameters.AddWithValue("status", jadwal.getStatus());
                    if (jadwal is JadwalFarmer farmer)
                    {
                        query1.Parameters.AddWithValue("idLahan", farmer.getIDLahan());
                        query1.Parameters.AddWithValue("idPelanggan", DBNull.Value);
                    }
                    else if (jadwal is JadwalPengantaran pengantaran)
                    {
                        query1.Parameters.AddWithValue("idLahan", DBNull.Value);
                        query1.Parameters.AddWithValue("idPelanggan", pengantaran.getIDPelanggan());
                    }
                    else
                    {
                        query1.Parameters.AddWithValue("idLahan", DBNull.Value);
                        query1.Parameters.AddWithValue("idPelanggan", DBNull.Value);
                    }
                    int DampakBaris = query1.ExecuteNonQuery();
                    if (DampakBaris > 0)
                    {
                        isSucces = true;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Gagal Update data: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSucces;
        }
    }
}
