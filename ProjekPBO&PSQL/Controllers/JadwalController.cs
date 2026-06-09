using System;
using System.Collections.Generic;
using System.Text;
using ProjekPBO_PSQL.Models;
using System.Windows.Forms;
using System.Data;

namespace ProjekPBO_PSQL.Controllers
{
    class JadwalController 
    {
        private JadwalContext Context = new JadwalContext();

        public DataTable GetAllJadwalOwner()
        {
            DataTable jadwalFarmer = Context.getjadwalFarmer();
            DataTable jadwalPengantar = Context.getJadwalPengantaran();
            jadwalFarmer.Merge(jadwalPengantar);

            return jadwalFarmer;
        }

        public DataTable GetAllJadwalOwnerHariIni()
        {
            DataTable jadwalFarmer = Context.getjadwalFarmerHariIni();
            DataTable jadwalPengantar = Context.getJadwalPengantaranHariIni();
            jadwalFarmer.Merge(jadwalPengantar);

            return jadwalFarmer;
        }

        public DataTable GetAllJadwalFarmerHariIni()
        {
            DataTable dataJadwalFarmer = Context.getjadwalFarmerHariIni();

            return dataJadwalFarmer;

        }

        public List<JadwalFarmer> GetAllJadwalFarmer(int id)
        {
            List<JadwalFarmer> DataJadwalFarmer = new List<JadwalFarmer>();
            if (id <= 0)
            {
                
                MessageBox.Show("ID Jadwal tidak valid", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return DataJadwalFarmer;
            }
            
            return Context.GetALLJadwalFarmer(id);
        }


        public DataTable GetAllJadwalPengantaranHariIni()
        {
            DataTable dataJadwalPengantar = Context.getJadwalPengantaranHariIni();

            return dataJadwalPengantar;

        }

        public List<JadwalPengantaran> GetAllJadwalPengantaran(int id)
        {
            List<JadwalPengantaran> DataJadwalPengantaran = new List<JadwalPengantaran>();
            if (id <= 0)
            {

                MessageBox.Show("ID jadwal tidak valid", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return DataJadwalPengantaran;
            }

            return Context.GetALLJadwalPengataran(id);
        }


        public bool tambahJadwal(Jadwal jadwal)
        {
            DateTime TanggalSekarang = DateTime.Today;
            if (jadwal.getTanggal().Date < TanggalSekarang)
            {
                MessageBox.Show("Tanggal Tidak Boleh Kemarin", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Validator.ApakahKosong(jadwal.getKeteranganKegiatan()))
            {
                MessageBox.Show("Keterangan jadwal tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Validator.ApakahKosong(jadwal.getTipeJadwal()))
            {
                MessageBox.Show("Tipe Jadwal tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return Context.ADDJadwal(jadwal);
        }


        public bool DelateJadwal(int id)
        {
            bool isSuccess = false; 
            if (id > 0)
            {
                try
                {
                    
                    isSuccess = Context.delateJadwal(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus Jadwal " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                }
            }

            return isSuccess;
        }

        public bool UpdateJadwal(Jadwal jadwal)
        {
            bool isSucces = false;
            try
            {
                
                isSucces = Context.UPDATEJadwal(jadwal);
            }
            catch 
            {
                isSucces = false;
            }

            return isSucces;
        }

        public bool UpdateStatusjadwal(Jadwal jadwal, string status)
        {
            bool isSucces = false;
            try
            {
                
                isSucces = Context.UPDATEJadwal(jadwal, status);
            }
            catch
            {
                return isSucces;
            }

            return isSucces;
        }
    }
}
