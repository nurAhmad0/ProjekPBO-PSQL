using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Tanaman
    {
        private int idTanaman;
        private string namaTanaman;
        private int hargaTanaman;
        private int estimasiKadaluarsa;

        public Tanaman(int idTanaman, string namaTanaman, int hargaTanaman, int estimasiKadaluarsa)
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

        public string getNamaTanaman()
        {
            return this.namaTanaman;
        }

        public int getHargaTanaman()
        {
            return this.hargaTanaman;
        }

        public int getEstimasiKadaluarsa()
        {
            return this.estimasiKadaluarsa;
        }
    }
}
