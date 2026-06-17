using ProjekPBO_PSQL.Helpers;
using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjekPBO_PSQL.Controllers
{
    class JadwalController 
    {
        private JadwalContext Context = new JadwalContext();

        public DataTable GetAllJadwalOwner() // menggabungkan jadi satu jadwal
        {
            DataTable jadwalFarmer = Context.getjadwalFarmer();
            DataTable jadwalPengantar = Context.getJadwalPengantaran();
            jadwalFarmer.Merge(jadwalPengantar);

            return jadwalFarmer;
        }

        public DataTable GetAllJadwalOwnerHariIni() //jadwal hari ini jadi satu 
        {
            DataTable jadwalFarmer = Context.getjadwalFarmerHariIni();
            DataTable jadwalPengantar = Context.getJadwalPengantaranHariIni();
            jadwalFarmer.Merge(jadwalPengantar);

            return jadwalFarmer;
        }

        public DataTable GetAllJadwalFarmerHariIni() //jadwal farmer hari ini
        {
            DataTable dataJadwalFarmer = Context.getjadwalFarmerHariIni();

            return dataJadwalFarmer;

        }

        public JadwalFarmer? GetAllJadwalFarmer(int id) //memasukkan id dari farmer
        {
            if (id <= 0)
            {
                
                MessageBox.Show("ID Jadwal tidak valid", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            
            return Context.GetALLJadwalFarmer(id);
        }


        public DataTable GetAllJadwalPengantaranHariIni() //jadwal pengantar hari ini
        {
            DataTable dataJadwalPengantar = Context.getJadwalPengantaranHariIni();

            return dataJadwalPengantar;

        }

        public JadwalPengantaran? GetAllJadwalPengantaran(int id) //buat detail
        {
            if (id <= 0)
            {

                MessageBox.Show("ID jadwal tidak valid", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return Context.GetALLJadwalPengataran(id);
        }


        public int tambahJadwal(Jadwal jadwal)
        {
            DateTime TanggalSekarang = DateTime.Today;
            if (jadwal.getTanggal().Date < TanggalSekarang)
            {
                MessageBox.Show("Tanggal Tidak Boleh Kemarin", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (Validator.ApakahKosong(jadwal.getKeteranganKegiatan()))
            {
                MessageBox.Show("Keterangan jadwal tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (Validator.ApakahKosong(jadwal.getTipeJadwal()))
            {
                MessageBox.Show("Tipe Jadwal tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
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

        public bool TambahDetailJadwal (int idKaryawan, int idjadwal)
        {
            bool isSucces = false;
            try
            {

                isSucces = Context.ADDDetailJadwal(idKaryawan,idjadwal);
            }
            catch
            {
                return isSucces;
            }

            return isSucces;
        }
    }
}
