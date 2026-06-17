using ProjekPBO_PSQL.Helpers;
using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    class GudangController : ISearch<Gudang>
    {
        GudangContext context = new GudangContext();

        public Gudang? Cari(int id)
        {
            if (id <= 0) return null;

            List<Gudang> getData = context.getAllGudang();

            foreach (var L in getData)
            {
                if (L.getIDGudang() == id)
                {
                    return L;

                }
            }

            return null;
        }

        public List<Gudang> Cari(string nama)
        {
            List<Gudang> dataLahan = new List<Gudang>();

            if (Validator.ApakahKosong(nama))
            {
                return dataLahan;
            }

            List<Gudang> getData = context.getAllGudang();

            foreach (var L in getData)
            {
                if (L.getNamaGudang().ToLower().Contains(nama.ToLower()))
                {
                    dataLahan.Add(L);
                }
            }

            return dataLahan;
        }


        public List<Gudang> GetAllGudang()
        {
            return context.getAllGudang();
        }

        public bool tambahGudang(Gudang gudang)
        {
            if (Validator.ApakahKosong(gudang.getNamaGudang()))
            {
                MessageBox.Show("Nama gudang Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (gudang.getStock() < 0)
            {
                MessageBox.Show("Stock Tidak Boleh Negatif", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return context.ADDGudang(gudang);
        }

        public bool updateGudang(Gudang gudang) 
        {
            bool isSucces = false;
            try
            {
                
                isSucces = context.UpdateGudang(gudang);
            }
            catch
            {
                MessageBox.Show("gagal Update data gudang", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

        public bool deletePelanggan(int id)
        {
            bool isSucces = false;
            try
            {
                
                isSucces = context.DelateGudang(id);
            }
            catch
            {
                MessageBox.Show("gagal hapus data Gudang", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

        public bool? ApakahAdaNamaGudang(string nama)

        {
            nama = nama.Trim();
            if (Validator.ApakahKosong(nama))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return context.ApakahAdaNamaGudang(nama);
        }

        public Gudang getDataGudangTerbaru(int idTanaman)
        {
            return context.GetGudangByTanaman(idTanaman);
        }
    }
}
