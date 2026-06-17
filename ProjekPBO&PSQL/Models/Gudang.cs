using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Gudang
    {
        private int IDGudang;
        private string NamaGudang;
        private decimal Stock;
        private DateTime TanggalMasuk;
        private int IDTanaman;
        private string namaTanaman;

        public Gudang(int iDGudang, string namaGudang, decimal stock, DateTime tanggalMasuk, int iDTanaman, string namaTanaman)
        {
            IDGudang = iDGudang;
            NamaGudang = namaGudang;
            Stock = stock;
            TanggalMasuk = tanggalMasuk;
            IDTanaman = iDTanaman;
            this.namaTanaman = namaTanaman;
        }

        public int getIDGudang()
        {
            return this.IDGudang;
        }

        public string getNamaTanaman()
        {
            return this.namaTanaman;
        }

        public string getNamaGudang()
        {
            return this.NamaGudang;
        }

        public decimal getStock()
        {
            return this.Stock;
        }

        public DateTime getTanggalMasuk()
        {
            return this.TanggalMasuk;
        }

        public int getIDTanaman()
        {
            return this.IDTanaman;
        }
    }
}
