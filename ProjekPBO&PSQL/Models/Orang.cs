using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Orang
    {
        protected string Name;
        protected int IDOrang;
        protected decimal Saldo;
        protected string NO_TELP;
        protected DateTime tanggalLahir;
        protected string Email;
        protected string StatusKerja;
        protected string NamaRole;
        protected int ID_Role;

        public Orang(int idOrang, string name, string NO_Telp, decimal saldo, DateTime TanggalLahir, string Email, string StatusKerja, string namaRole, int ID_Role)
        {
            this.Name = name;
            this.IDOrang = idOrang;
            this.Saldo = saldo;
            this.NO_TELP = NO_Telp;
            this.tanggalLahir = TanggalLahir;
            this.Email = Email;
            this.StatusKerja = StatusKerja;
            this.NamaRole = namaRole;
            this.ID_Role = ID_Role;
        }

        public decimal TarikSaldo(decimal TarikUang)
        {
            if (TarikUang > 10000 && TarikUang < 5000000)
            {
                decimal sisaUang= Saldo - TarikUang;
                return sisaUang;
            }
            else
            {
                return 0;
            }
        }

        public string getName()
        {
            return this.Name;
        }

        public int getIDOrang()
        {
            return this.IDOrang;
        }

        public decimal getSaldo()
        {
            return this.Saldo;
        }

        public string getNO_TELP()
        {
            return this.NO_TELP;
        }

        public DateTime getTanggalLahir()
        {
            return this.tanggalLahir;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public string getStatus()
        {
            return this.StatusKerja;
        }

        public string getNamaRole()
        {
            return this.NamaRole;
        }

        public int getId_Role()
        {
            return this.ID_Role;
        }
    }
}
