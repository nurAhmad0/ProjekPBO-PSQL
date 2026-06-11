using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Lahan
    {
        private int idLahan;
        private string namaLahan;
        private decimal luasLahan;
        private string statusLahan;

        public Lahan(int idLahan, string namaLahan, decimal luasLahan, string statusLahan)
        {
            this.idLahan = idLahan;
            this.namaLahan = namaLahan;
            this.luasLahan = luasLahan;
            this.statusLahan = statusLahan;
        }

        public int getIdLahan()
        {
            return this.idLahan;
        }
        public string DisplayLahan => this.namaLahan;
        public int id_Lahan => this.idLahan;

        public string getNamaLahan()
        {
            return this.namaLahan;
        }

        public decimal getLuasLahan()
        {
            return this.luasLahan;
        }

        public string getStatusLahan()
        {
            return this.statusLahan;
        }
    }
}
