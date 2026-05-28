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
        private int IDLahan;
        private int IDTanaman;

        public PenanamanLahan(int iDPenanaman, DateTime tanggalDItanam, int jumlahTanaman, string statusPenanaman, int iDLahan, int iDTanaman)
        {
            IDPenanaman = iDPenanaman;
            TanggalDItanam = tanggalDItanam;
            this.jumlahTanaman = jumlahTanaman;
            this.statusPenanaman = statusPenanaman;
            IDLahan = iDLahan;
            IDTanaman = iDTanaman;
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

        public int getIDLahan()
        {
            return this.IDLahan;
        }

        public int getIDTanaman() 
        {
            return this.IDTanaman;
        }

        public DateTime getTanggalDitanam()
        {
            return this.TanggalDItanam;
        }
    }
}
