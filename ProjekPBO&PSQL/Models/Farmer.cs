using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Farmer : Orang
    {
        public Farmer(int idOrang, string name, string NO_Telp, decimal saldo, DateTime TanggalLahir, string Email, string StatusKerja, int ID_Role) : base(idOrang, name, NO_Telp, saldo, TanggalLahir, Email, StatusKerja, "Farmer", ID_Role)
        {
        }
    }
}
