using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Tanaman
    {
        private int idTanaman;
        private string namaTanaman;
        private decimal hargaTanaman;
        private int estimasiKadaluarsa;

        public Tanaman(int idTanaman, string namaTanaman, decimal hargaTanaman, int estimasiKadaluarsa)
        {
            this.idTanaman = idTanaman;
            this.namaTanaman = namaTanaman;
            this.hargaTanaman = hargaTanaman;
            this.estimasiKadaluarsa = estimasiKadaluarsa;
        }

        public int getIdTanaman()
        {
            return this.idTanaman;
        }

        public string nama_tanaman => this.namaTanaman;
        public int id_tanaman => this.idTanaman;

        public string getNamaTanaman()
        {
            return this.namaTanaman;
        }

        public decimal getHargaTanaman()
        {
            return this.hargaTanaman;
        }

        public int getEstimasiKadaluarsa()
        {
            return this.estimasiKadaluarsa;
        }
    }
}
