using ProjekPBO_PSQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjekPBO_PSQL.Controllers
{
    class RiwayatPenarikanController
    {

        PenarikanContext context = new PenarikanContext();

        public DataTable TampilSemuaPenarikan()
        {
            return context.GetAllDataPenarikan();
        }

        public bool TambahRiwayat(decimal nominal, string metodePenarikan, int idAnggota)
        {
            if (nominal > 0 && idAnggota > 0 && !string.IsNullOrEmpty(metodePenarikan))
            {
                return context.TambahRiwayatPenarikan(nominal, metodePenarikan, idAnggota);
            }
            return false;
        }

        public bool KonfirmasiPencairan(int idPenarikan)
        {
            if (idPenarikan > 0)
            {
                return context.UpdateStatusRiwayat(idPenarikan);
            }
            return false;
        }
    }
}
