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
        private string Status;
        private List<DetailAnggotaJadwal> daftarAnggota;
        private decimal TotalUpah;

        public Jadwal(int idJadwal, DateTime tanggal, string keteranganKegiatan, string tipeJadwal, int banyakAnggota, string status, decimal totalUpah)
        {
            this.IdJadwal = idJadwal;
            this.tanggal = tanggal;
            this.KeteranganKegiatan = keteranganKegiatan;
            this.TipeJadwal = tipeJadwal;
            this.BanyakAnggota = banyakAnggota;
            this.Status = status;
            this.daftarAnggota = new List<DetailAnggotaJadwal>();
            TotalUpah = totalUpah;
        }

        public List<DetailAnggotaJadwal> getDaftarAnggota()
        {
            return this.daftarAnggota;
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

        public string getStatus()
        {
            return Status;
        }

        public decimal getTotalUpah()
        {
            return TotalUpah;
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

        public void setStatus(string status)
        {
            this.Status = status;
        }
    }
}
