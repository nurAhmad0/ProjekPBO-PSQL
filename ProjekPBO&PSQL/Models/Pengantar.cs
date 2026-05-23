using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    class Pengantar : Orang
    {
        public Pengantar(string name, int idOrang, decimal saldo) : base(name, idOrang, saldo)
        {
        }
        public override void MelihatJadwalOP()
        {
            throw new NotImplementedException();
        }
        public override void MelihatJadwalHariIni()
        {
            throw new NotImplementedException();
        }
    }
}
