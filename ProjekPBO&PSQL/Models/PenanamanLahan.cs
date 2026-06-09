using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class PenanamanLahan
    {
        private int IDPenanaman;
        private DateTime TanggalDItanam;
        private int jumlahTanaman;
        private string statusPenanaman;
        private Lahan LahanTempatMenanam;
        private Tanaman JenisTanaman;

        public PenanamanLahan(int iDPenanaman, DateTime tanggalDItanam, int jumlahTanaman, string statusPenanaman, Lahan lahan, Tanaman tanaman)
        {
            IDPenanaman = iDPenanaman;
            TanggalDItanam = tanggalDItanam;
            this.jumlahTanaman = jumlahTanaman;
            this.statusPenanaman = statusPenanaman;
            this.LahanTempatMenanam = lahan;
            this.JenisTanaman = tanaman;


        }

        
        public Tanaman getJenisTanaman()
        {
            return this.JenisTanaman;
        }


        public Lahan getLahanTempatMenanam()
        {
            return this.LahanTempatMenanam;
        }

        public int getIDPenanaman()
        {
            return this.IDPenanaman;
        }

        public string getStatusPenanaman()
        {
            return this.statusPenanaman;
        }

        public int getJumlahTanaman()
        {
            return this.jumlahTanaman;
        }

        public DateTime getTanggalDitanam()
        {
            return this.TanggalDItanam;
        }
    }
}
