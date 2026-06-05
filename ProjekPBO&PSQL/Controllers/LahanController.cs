using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    class LahanController : ISearch<Lahan>
    {
        private LahanContext Context = new LahanContext();

        public List<Lahan> CariBerdasarkanID(int id)
        {
            List<Lahan> dataLahan = new List<Lahan>();

            List<Lahan> getData = Context.GETALLLahan();

            foreach (var L in getData)
            {
                if (L.getIdLahan() == id)
                {
                    dataLahan.Add(L);
                    break;
                }
            }

            return dataLahan;
        }

        public List<Lahan> CariBerdasarkanNama(string nama)
        {
            List<Lahan> dataLahan = new List<Lahan>();

            if (Validator.ApakahKosong(nama))
            {
                return dataLahan;
            }

            List<Lahan> getData = Context.GETALLLahan();

            foreach (var L in getData)
            {
                if (L.getNamaLahan().ToLower().Contains(nama.ToLower()))
                {
                    dataLahan.Add(L);
                }
            }

            return dataLahan;
        }


        public List<Lahan> GetAllLahan()
        {
            return Context.GETALLLahan();
        }

        public bool TambahLahan(Lahan lahan)
        {
            if (Validator.ApakahKosong(lahan.getNamaLahan()) && Validator.ApakahAngka(lahan.getNamaLahan()))
            {
                MessageBox.Show("Nama Lahan Tidak Boleh Kosong dan Hanya Angka!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lahan.getLuasLahan() < 0)
            {
                MessageBox.Show("Luas Lahan Tidak Bisa Negatif", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Validator.ApakahKosong(lahan.getStatusLahan()))
            {
                MessageBox.Show("Status Tidak Bisa Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Context.AddLahan(lahan);
            return true;
        }

        public bool updateLahan(Lahan lahan)
        {
            bool isSucces = false;
            try
            {
                Context.UPDATELahan(lahan);
                isSucces = true;
            }
            catch
            {
                MessageBox.Show("gagal Update Lahan", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }


        public bool DeleteLahan(int id)
        {
            bool isSucces = false;
            try
            {
                Context.DELETELahan(id);
                isSucces = true;
            }
            catch
            {
                MessageBox.Show("gagal Hapus Lahan", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

        public bool? CekNamaLahanDiDataBase(string nama)
        {
            if (Validator.ApakahKosong(nama))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return Context.ApakahAdaNamaLahan(nama);
        }
    }
}
