using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Owner : Orang
    {
        public Owner(int idOrang, string name, string NO_Telp, decimal saldo, DateTime TanggalLahir, string Email, string StatusKerja, int ID_Role, string username, string password) : base(idOrang, name, NO_Telp, saldo, TanggalLahir, Email, StatusKerja, "Owner", ID_Role, username, password)
        {
        }
        public override decimal? TarikSaldo(decimal TarikUang)
        {
            if (TarikUang < 10000)
            {
                return null;
            }
            if (TarikUang > 500000000)
            {
                return null;
            }

            if ((Saldo - TarikUang) < 0)
            {
                return null;
            }

            Saldo -= TarikUang;
            return TarikUang;
        }
    }
}
