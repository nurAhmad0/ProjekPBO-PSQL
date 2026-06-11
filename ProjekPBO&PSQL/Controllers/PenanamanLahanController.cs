using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    class PenanamanLahanController
    {
        PenanamanLahanCOntext context = new PenanamanLahanCOntext();

        public List<PenanamanLahan> GetAllPenanamanLahan()
        {
            return context.GETALLPenanamanLahan();
        }

        public bool TambahTanamanLahan(PenanamanLahan penanaman)
        {
            if (penanaman.getJumlahTanaman() <= 0)
            {
                MessageBox.Show("Jumlah tanaman harus lebih dari 0!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Validator.ApakahKosong(penanaman.getStatusPenanaman()))
            {
                MessageBox.Show("Status penanaman tidak boleh kosong!", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return context.ADDPenanamanLahan(penanaman);
        }
        public bool DeletePenanamanLahan(int id)
        {
            bool isSucces = false;
            try
            {
                isSucces = context.DELETEPenanamanLahan(id);
            }
            catch
            {
                MessageBox.Show("Gagal Hapus Data Penanaman Lahan", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }

    }
}
