using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Controllers
{
    class OrangController
    {
        private OrangContext Context = new OrangContext();

        public List<Orang> CariBerdasarkanID(int id)
        {
            List<Orang> dataOrang = new List<Orang>();

            List<Orang> getData = GetAllKaryawan();

            foreach (var L in getData)
            {
                if (L.getIDOrang() == id)
                {
                    dataOrang.Add(L);
                    break;
                }
            }

            return dataOrang;
        }

        public List<Orang> CariBerdasarkanNama(string nama)
        {
            List<Orang> dataOrang = new List<Orang>();

            if (Validator.ApakahKosong(nama))
            {
                return dataOrang;
            }

            List<Orang> getData = GetAllKaryawan();

            foreach (var L in getData)
            {
                if (L.getName().ToLower().Contains(nama.ToLower()))
                {
                    dataOrang.Add(L);
                }
            }

            return dataOrang;
        }

        public List<Orang> GetAllKaryawan()
        {
            List<Orang> dataOrang = new List<Orang>();
            List<Farmer> dataFarmer = Context.getAllOrangFarmer();
            List<Pengantar> dataPengantar = Context.getAllOrangPengantar();
            List<Owner> dataOwner = Context.getAllOrangOwner();

            foreach (Farmer f in dataFarmer)
            {
                dataOrang.Add(f);
            }

            foreach (Pengantar p in dataPengantar)
            {
                dataOrang.Add(p);
            }

            foreach(Owner o in dataOwner)
            {
                dataOrang.Add(o);
            }

            return dataOrang;
        }

        public List<Farmer> GetAllOrangFarmer()
        {
            return Context.getAllOrangFarmer();
        }

        public List<Pengantar> GetAllOrangPengantar()
        {
            return Context.getAllOrangPengantar();
        }

        public List<Owner> GetAllOrangOwner()
        {
            return Context.getAllOrangOwner();
        }

        public bool TambahOrang(Orang orang)
        {
            if (Validator.ApakahKosong(orang.getName()))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validator.ApakahPanjang(10, orang.getNO_TELP(), 12))
            {
                MessageBox.Show("No telp Harus terdiri dari 10 - 12", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validator.ApakahEmailValid(orang.getEmail()))
            {
                MessageBox.Show("Email harus Valid", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Validator.ApakahKosong(orang.getUsername()))
            {
                MessageBox.Show("Username Tidak Boleh kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Validator.ApakahKosong(orang.getPassword()))
            {
                MessageBox.Show("Password Tidak boleh kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Validator.ApakahKosong(orang.getStatus()))
            {
                MessageBox.Show("Status Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Context.ADDOrang(orang);
            return true;
        }

        public bool UbahPassword(Orang orang, string password)
        {
            bool isSucces = false;
            try
            {
                Context.UpdateOrang(orang, Password: password);
                isSucces = true;
            }
            catch
            {
                MessageBox.Show("Gagal", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

        public bool UbahUsername (Orang orang, string username)
        {
            bool isSucces = false;
            try
            {
                Context.UpdateOrang(orang, Username: username);
                isSucces = true;
            }
            catch
            {
                MessageBox.Show("Gagal", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

        public bool UpdateOrang (Orang orang)
        {
            bool isSucces = false;
            try
            {
                Context.UpdateOrang(orang);
                isSucces = true;
            }
            catch
            {
                MessageBox.Show("Gagal", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }


        public bool DeleteOrang(int id)
        {
            bool isSuccess = false; 
            if (id > 0)
            {
                try
                {
                    Context.DelateOrang(id); 
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus tanaman: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                }
            }

            return isSuccess;
        }
    }
}
