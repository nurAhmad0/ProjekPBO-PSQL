using System;
using System.Collections.Generic;
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

        public Jadwal(int idJadwal, DateTime tanggal, string keteranganKegiatan, string tipeJadwal, int banyakAnggota)
        {
            this.IdJadwal = idJadwal;
            this.tanggal = tanggal;
            this.KeteranganKegiatan = keteranganKegiatan;
            this.TipeJadwal = tipeJadwal;
            this.BanyakAnggota = banyakAnggota;
        }

        public int getIdJadwal()
        {
            return IdJadwal;
        }

        public DateTime getTanggal()
        {
            return tanggal;
        }
    }
}
