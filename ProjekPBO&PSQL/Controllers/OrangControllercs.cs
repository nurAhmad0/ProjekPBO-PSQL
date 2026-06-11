using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjekPBO_PSQL.Controllers
{
    class OrangController
    {
        private OrangContext Context = new OrangContext();


        //public List<Orang> CariBerdasarkanID(int id)
        //{
        //    List<Orang> dataOrang = new List<Orang>();

        //    List<Orang> getData = GetAllKaryawan();

        //    foreach (var L in getData)
        //    {
        //        if (L.getIDOrang() == id)
        //        {
        //            dataOrang.Add(L);
        //            break;
        //        }
        //    }

        //    return dataOrang;
        //}

        public Orang? CariBerdasarkanID(int id)
        {
            if (id <= 0) return null;

            List<Orang> getData = GetAllKaryawan();

            foreach (var L in getData)
            {
                if (L.getIDOrang() == id)
                {
                    return L;

                }
            }
            return null;
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

            
            return Context.ADDOrang(orang);
        }

        public bool UbahPassword(Orang orang, string password)
        {
            bool isSucces = false;
            try
            {
                
                isSucces = Context.UpdateOrang(orang, Password: password);
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
                
                isSucces = Context.UpdateOrang(orang, Username: username);
            }
            catch
            {
                MessageBox.Show("Gagal", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

        public bool UbbahStatusKerja (Orang orang, string status)
        {
            bool isSucces = false;
            try
            {

                isSucces = Context.UpdateOrang(orang, Status: status);
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
                
                isSucces = Context.UpdateOrang(orang);
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
                    
                    isSuccess = Context.DelateOrang(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus data: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                }
            }

            return isSuccess;
        }


        public bool UpdateSaldo(int id, decimal saldo)
        {
            bool isSuccess = false;
            if (id > 0)
            {
                try
                {
                    
                    isSuccess = Context.UpdateSaldo(id, saldo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update data: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                }
            }

            return isSuccess;
        }

        public bool? apakahAdaNoTelp(string NOTELP)
        {
            NOTELP = NOTELP.Trim();
            if (Validator.ApakahKosong(NOTELP) || !Validator.ApakahPanjang(10, NOTELP, 12))
            {
                MessageBox.Show("Nomer telpon Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return Context.ApakahAdaNOTELP(NOTELP);
        }

        public bool? apakahAdaEmail(string Email)
        {
            Email = Email.Trim();
            if (Validator.ApakahKosong(Email) || !Validator.ApakahEmailValid(Email))
            {
                MessageBox.Show("Email Tidak Boleh Kosong dan tidak valid", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return Context.ApakahAdaEmail(Email);
        }

        public bool? apakahAdaUsername(string username)
        {
            username = username.Trim();
            if (Validator.ApakahKosong(username))
            {
                MessageBox.Show("Nomer Username Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return Context.ApakahAdaUsername(username);
        }


        public Tuple<int, int> LoginOtentikasi(string username, string password)
        {
            if (Validator.ApakahKosong(username) || Validator.ApakahKosong(password))
            {
                MessageBox.Show("Username dan Password Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new Tuple<int, int>(0, 0);
            }

            return Context.GetIdAnggotadanRole(username, password);
        }
    }
}
