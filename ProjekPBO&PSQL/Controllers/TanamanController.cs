using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ProjekPBO_PSQL.Controllers
{
    class TanamanController : ISearch<Tanaman>
    {
        private TanamanContext Context = new TanamanContext();

        //public List<Tanaman> Cari(int id)
        //{
        //    List<Tanaman> dataTanaman = new List<Tanaman>();

        //    List<Tanaman> getData = Context.GETALLTanaman();

        //    foreach (var L in getData)
        //    {
        //        if (L.getIdTanaman() == id)
        //        {
        //            dataTanaman.Add(L);
        //            break;
        //        }
        //    }

        //    return dataTanaman;
        //}

        public Tanaman? Cari(int id)
        {
            if (id <= 0) return null;

            List<Tanaman> getData = Context.GETALLTanaman();

            foreach (var L in getData)
            {
                if (L.getIdTanaman() == id)
                {
                    return L;

                }
            }

            return null;
        }

        public List<Tanaman> Cari(string nama)
        {
            List<Tanaman> dataTanaman = new List<Tanaman>();

            if (Validator.ApakahKosong(nama))
            {
                return dataTanaman;
            }

            List<Tanaman> getData = Context.GETALLTanaman();

            foreach (var L in getData)
            {
                if (L.getNamaTanaman().ToLower().Contains(nama.ToLower()))
                {
                    dataTanaman.Add(L);
                }
            }

            return dataTanaman;
        }

        public DataTable GetDataTanamanBerdasarkanBulan()
        {
            return Context.getJumlahTanamanBerdasarkanBulan();
        }

        public DataTable getAllHistoriHarga()
        {
            return Context.getALLHistoriHarga();
        }

        public bool DeleteTanaman(int id)
        {
            bool isSuccess = false; 
            if (id > 0)
            {
                try
                {
                   
                    isSuccess = Context.DelateTanaman(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus tanaman: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                }
            }

            return isSuccess;
        }


        public bool UpdateTanaman(Tanaman tanaman)
        {
            bool isSucces = false;
            try
            {
                
                isSucces = Context.UpdateTanaman(tanaman);
            }
            catch
            {
                isSucces = false;
            }

            return isSucces;
        }

        public bool TambahTanaman(Tanaman tanaman)
        {
            if (Validator.ApakahKosong(tanaman.getNamaTanaman()))
            {
                MessageBox.Show("Nama Tanaman tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tanaman.getEstimasiKadaluarsa() <= 0 )
            {
                MessageBox.Show("Estimasi kadaluarsa Tidak Bisa 0!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            return Context.ADDTanaman(tanaman);
        }

        public List<Tanaman> GetAllTanaman()
        {
            return Context.GETALLTanaman();
        }


        public DataTable Get10TanamanPalingDIbeli()
        {
            return Context.get10TanamanPalingBanyakDibeli();
        }

        public DataTable GetTanamanBelumlaku()
        {
            return Context.getTanamanYangBelumTerjual();
        }

        public int getUsiaTanaman(int idLahan, int idTanaman)
        {
            return Context.HitungUsiaTanaman(idLahan, idTanaman);
        }

        public bool? ApakahAdaNamaTanaman(string nama)
        {
            nama = nama.Trim();
            if (Validator.ApakahKosong(nama))
            {
                MessageBox.Show("Nama Tidak Boleh Kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return Context.ApakahAdaNamaTanaman(nama);
        }
    }
}
