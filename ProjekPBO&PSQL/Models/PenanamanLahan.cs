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

        public PenanamanLahan(int iDPenanaman, DateTime tanggalDItanam, int jumlahTanaman, string statusPenanaman, int idLahan, string namaLahan, decimal luasLahan, string statusLahan, int idTanaman, string namaTanaman, int hargaTanaman, int estimasiKadaluarsa)
        {
            IDPenanaman = iDPenanaman;
            TanggalDItanam = tanggalDItanam;
            this.jumlahTanaman = jumlahTanaman;
            this.statusPenanaman = statusPenanaman;
            this.LahanTempatMenanam = new Lahan(idLahan, namaLahan, luasLahan, statusLahan);
            this.JenisTanaman = new Tanaman(idTanaman, namaTanaman, hargaTanaman, estimasiKadaluarsa);
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
