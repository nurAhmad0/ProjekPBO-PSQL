using ProjekPBO_PSQL.Helpers;
using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    class LahanController : ISearch<Lahan>
    {
        private LahanContext Context = new LahanContext();

        public Lahan? Cari(int id)
        {
            if (id <= 0) return null;

            List<Lahan> getData = Context.GETALLLahan();

            foreach (var L in getData)
            {
                if (L.getIdLahan() == id)
                {
                    return L;
                    
                }
            }

            return null;
        }

        public List<Lahan> Cari(string nama)
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
            if (Validator.ApakahKosong(lahan.getNamaLahan()))
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

            
            return Context.AddLahan(lahan);
        }

        public bool updateLahan(Lahan lahan)
        {
            bool isSucces = false;
            try
            {
                
                isSucces = Context.UPDATELahan(lahan);
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
                
                isSucces = Context.DELETELahan(id);
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
                return null;
            }

            return Context.ApakahAdaNamaLahan(nama.Trim());
        }

        public List<Lahan> getLahanTersedia()
        {
            return Context.GetLahanTersedia();
        }


        public List<Lahan> getLahanSedangDitanam()
        {
            return Context.GetLahanSedangDitanam();
        }
    }
}
