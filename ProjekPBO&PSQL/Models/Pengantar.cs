using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models

{
    class Pengantar : Orang
    {
        public Pengantar(int idOrang, string name, string NO_Telp, decimal saldo, DateTime TanggalLahir, string Email, string StatusKerja, int ID_Role, string username, string password) : base(idOrang, name, NO_Telp, saldo, TanggalLahir, Email, StatusKerja, "Pengantar", ID_Role, username, password)
        {
        }
    }
}
