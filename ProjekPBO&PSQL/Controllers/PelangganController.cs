using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    class PelangganController : ISearch<Pelanggan>
    {
        private PelangganContext Context = new PelangganContext();

        //public List<Pelanggan> CariBerdasarkanID(int id)
        //{
        //    List<Pelanggan> dataPelanggan = new List<Pelanggan>();

        //    List<Pelanggan> getData = Context.getAllPelanggan();

        //    foreach (var L in getData)
        //    {
        //        if (L.getIdPelanggan() == id)
        //        {
        //            dataPelanggan.Add(L);
        //            break;
        //        }
        //    }

        //    return dataPelanggan;
        //}

        public Pelanggan? CariBerdasarkanID(int id)
        {
            if (id <= 0) return null;

            List<Pelanggan> getData = Context.getAllPelanggan();

            foreach (var L in getData)
            {
                if (L.getIdPelanggan() == id)
                {
                    return L;

                }
            }
            return null;
        }

        public List<Pelanggan> CariBerdasarkanNama(string nama)
        {
            List<Pelanggan> dataPelanggan = new List<Pelanggan>();

            if (Validator.ApakahKosong(nama))
            {
                return dataPelanggan;
            }

            List<Pelanggan> getData = Context.getAllPelanggan();

            foreach (var L in getData)
            {
                if (L.getNamePelanggan().ToLower().Contains(nama.ToLower()))
                {
                    dataPelanggan.Add(L);
                }
            }

            return dataPelanggan;
        }

        public List<Pelanggan> GetAllPelanggan()
        {
            return Context.getAllPelanggan();
        }

        public bool TambahPelanggan(Pelanggan pelanggan)
        {
            if (Validator.ApakahKosong(pelanggan.getNamePelanggan()))
            {
                MessageBox.Show("Nama Pelangan Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validator.ApakahPanjang(10, pelanggan.getNO_TELP(), 12))
            {
                MessageBox.Show("No telp Harus terdiri dari 10 - 12", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validator.ApakahEmailValid(pelanggan.getEmail()))
            {
                MessageBox.Show("Email harus Valid", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Validator.ApakahKosong(pelanggan.getDetailAlamat()))
            {
                MessageBox.Show("Detail Alamat Tidak Boleh kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            return Context.ADDPelanggan(pelanggan);
        }

        public bool updatePelanggan(Pelanggan pelanggan)
        {
            bool isSucces = false;
            try
            {
                
                isSucces = Context.UpdatePelanggan(pelanggan);
            }
            catch
            {
                MessageBox.Show("gagal Update data Pelanggan", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

        public bool deletePelanggan(int id)
        {
            bool isSucces = false;
            try
            {
                
                isSucces = Context.DelatePelanggan(id);
            }
            catch
            {
                MessageBox.Show("gagal hapus data Pelanggan", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

        public bool? apakahAdaNoTelp(string NOTELP)
        {
            if (Validator.ApakahKosong(NOTELP) || !Validator.ApakahPanjang(10, NOTELP, 12))
            {
                MessageBox.Show("Nomer telpon Tidak Boleh Kosong dan harus sesuai", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return Context.ApakahAdaNOTELP(NOTELP.Trim());
        }

        public bool? apakahAdaEmail(string Email)
        {
            if (Validator.ApakahKosong(Email) || !Validator.ApakahEmailValid(Email))
            {
                MessageBox.Show("Email Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return Context.ApakahAdaEmail(Email.Trim());
        }
    }
}
