using System;
using System.Collections.Generic;
using System.Text;
using ProjekPBO_PSQL.Models;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Controllers
{
    class JadwalController 
    {
        private JadwalContext Context = new JadwalContext();

        public List<Jadwal> GetAllJadwalOwner()
        {
            List<Jadwal> jadwalOwner = new List<Jadwal>();
            List<JadwalFarmer> jadwalFarmer = Context.GetALLJadwalFarmer();
            List<JadwalPengantaran> jadwalPengantar = Context.GetALLJadwalPengataran();

            foreach (var Jf in jadwalFarmer)
            {
                jadwalOwner.Add(Jf);
            }

            foreach (var Jp in jadwalPengantar)
            {
                jadwalOwner.Add(Jp);
            }

            return jadwalOwner;
        }

        public List<Jadwal> GetAllJadwalOwnerHariIni()
        {
            List<Jadwal> jadwalOwner = new List<Jadwal>();
            List<JadwalFarmer> jadwalFarmer = GetAllJadwalFarmerIni();
            List<JadwalPengantaran> jadwalPengantar = GetAllJadwalPengantaranHariIni();

            DateTime TanggalSekarang = DateTime.Today;

            foreach (var Jf in jadwalFarmer)
            {
                if (Jf.getTanggal().Date == TanggalSekarang)
                {
                    jadwalOwner.Add(Jf);
                }
            }

            foreach (var Jp in jadwalPengantar)
            {
                if (Jp.getTanggal().Date == TanggalSekarang)
                {
                    jadwalOwner.Add(Jp);
                }
            }

            return jadwalOwner;

        }

        public List<JadwalFarmer> GetAllJadwalFarmerIni()
        {
            List<JadwalFarmer> dataJadwalFarmer = new List<JadwalFarmer>();

            List<JadwalFarmer> jadwalFarmer = Context.GetALLJadwalFarmer();

            DateTime TanggalSekarang = DateTime.Today;

            foreach (var Jf in jadwalFarmer)
            {
                if (Jf.getTanggal().Date == TanggalSekarang)
                {
                    dataJadwalFarmer.Add(Jf);
                }
            }

            return dataJadwalFarmer;

        }

        public List<JadwalFarmer> GetAllJadwalFarmer()
        {
            return Context.GetALLJadwalFarmer();
        }


        public List<JadwalPengantaran> GetAllJadwalPengantaranHariIni()
        {
            List<JadwalPengantaran> dataJadwalPengantaran = new List<JadwalPengantaran>();

            List<JadwalPengantaran> jadwalPengantaran = Context.GetALLJadwalPengataran();

            DateTime TanggalSekarang = DateTime.Today;

            foreach (var Jp in jadwalPengantaran)
            {
                if (Jp.getTanggal().Date == TanggalSekarang)
                {
                    dataJadwalPengantaran.Add(Jp);
                }
            }

            return dataJadwalPengantaran;
        }

        public List<JadwalPengantaran> GetAllJadwalPengantaran()
        {
            return Context.GetALLJadwalPengataran();
        }


        public bool tambahJadwal(Jadwal jadwal)
        {
            bool isSucces = false;
            DateTime TanggalSekarang = DateTime.Today;
            if (jadwal.getTanggal().Date < TanggalSekarang)
            {
                isSucces = false;
                MessageBox.Show("Tanggal Tidak Boleh Kemarin", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return isSucces;
            }
            else
            {
                if (!Validator.ApakahKosong(jadwal.getKeteranganKegiatan()) & Validator.ApakahHurufdanAngka(jadwal.getKeteranganKegiatan()) & !Validator.ApakahAngka(jadwal.getKeteranganKegiatan()))
                {
                    if (Validator.ApakahKosong(jadwal.getTipeJadwal()))
                    {
                        isSucces = false;
                        MessageBox.Show("Tipe Jadwal Salah", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return isSucces;
                    }
                    else
                    {
                        Context.ADDJadwal(jadwal);
                        isSucces = true;
                        return isSucces;
                    }
                }
                else
                {
                    isSucces = false;
                    MessageBox.Show("Keterangan jadwal tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return isSucces;
                }

            }
        }


        public bool DelateJadwal(int id)
        {
            bool isSuccess = false; 
            if (id > 0)
            {
                try
                {
                    Context.delateJadwal(id); 
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus tanaman: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Context.UPDATEJadwal(jadwal);
                isSucces = true;
            }
            catch 
            {
                isSucces = false;
            }

            return isSucces;
        }

    }
}
