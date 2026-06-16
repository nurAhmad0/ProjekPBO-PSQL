using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ProjekPBO_PSQL.Controllers;

namespace ProjekPBO_PSQL.Models
{
    class Pelanggan
    {
        private int IdPelanggan;
        private string NamePelanggan;
        private string NO_Telp;
        private string Email;
        private string DetailAlamat;

        public Pelanggan(int idPelanggan, string namePelanggan, string no_Telp, string email, string detailAlamat)
        {
            this.IdPelanggan = idPelanggan;
            this.NamePelanggan = namePelanggan;
            this.NO_Telp = no_Telp;
            this.Email = email;
            this.DetailAlamat = detailAlamat;
        }

        public int getIdPelanggan()
        {
            return this.IdPelanggan; 
        }

        public string getNamePelanggan()
        {
            return this.NamePelanggan;
        }

        public string getNO_TELP()
        {
            if (ProjekPBO_PSQL.Controllers.Validator.ApakahPanjang(10, this.NO_Telp, 13))
            {
                return this.NO_Telp;
            }
            else
            {
                return "-";
            }
        }

        public string getEmail()
        {
            if (ProjekPBO_PSQL.Controllers.Validator.ApakahEmailValid(Email))
            {
                return this.Email;
            }
            else
            {
                return "Tidak Ada Email";
            }
        }

        public string getDetailAlamat()
        {
            if (DetailAlamat != null)
            {
                return DetailAlamat;
            }
            else
            {
                return "Alamat Tidak Ada";
            }
        }    

        public string namaPelanggan => this.NamePelanggan;
        public int idPelanggan => this.IdPelanggan;
    }
}
