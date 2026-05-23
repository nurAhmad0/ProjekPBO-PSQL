using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Jadwal
    {
        private int IdJadwal;
        private DateTime tanggal;
        private string KeteranganKegiatan;
        private string TipeJadwal;
        private int BanyakAnggota;
        private List<int> IDAnggota;
        private List<string> NamaAnggota;
        private string Status;

        public Jadwal(int idJadwal, DateTime tanggal, string keteranganKegiatan, string tipeJadwal, int banyakAnggota, List<int> iDAnggota, List<string> namaAnggota, string status)
        {
            this.IdJadwal = idJadwal;
            this.tanggal = tanggal;
            this.KeteranganKegiatan = keteranganKegiatan;
            this.TipeJadwal = tipeJadwal;
            this.BanyakAnggota = banyakAnggota;
            this.IDAnggota = iDAnggota;
            this.NamaAnggota = namaAnggota;
            this.Status = status;
        }

        public int getIdJadwal()
        {
            return IdJadwal;
        }

        public DateTime getTanggal()
        {
            return tanggal;
        }

        public string getKeteranganKegiatan()
        {
            return KeteranganKegiatan;
        }

        public string getTipeJadwal()
        {
            return TipeJadwal;
        }

        public int getBanyakAnggota()
        {
            return BanyakAnggota;
        }

        public List<int> getIDAnggota()
        {
            return IDAnggota;
        }

        public List<string> getNamaAnggota()
        {
            return NamaAnggota;
        }

        public string getStatus()
        {
            return Status;
        }

        public void setTanggal(DateTime tanggal)
        {
            this.tanggal = tanggal;
        }

        public void setKeteranganKegiatan(string keteranganKegiatan)
        {
            this.KeteranganKegiatan = keteranganKegiatan;
        }

        public void setTipeJadwal(string tipeJadwal)
        {
            this.TipeJadwal = tipeJadwal;
        }

        public void setBanyakAnggota(int banyakAnggota)
        {
            this.BanyakAnggota = banyakAnggota;
        }

        public void setNamaAnggota(List<string> namaAnggota)
        {
            this.NamaAnggota = namaAnggota;
        }

        public void setStatus(string status)
        {
            this.Status = status;
        }
    }
}
