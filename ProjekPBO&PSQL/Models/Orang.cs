using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    abstract class Orang
    {
        protected string Name;
        protected int IDOrang;
        protected decimal Saldo;

        public Orang(string name, int idOrang, decimal saldo)
        {
            this.Name = name;
            this.IDOrang = idOrang;
            this.Saldo = saldo;
        }
        public abstract void MelihatJadwalOP();
        public abstract void MelihatJadwalHariIni();
    }
}
