using System;
using System.Collections.Generic;
using System.Text;
using ProjekPBO_PSQL.Models;
using System.Windows.Forms;
using ProjekPBO_PSQL.Helpers;

namespace ProjekPBO_PSQL.Controllers
{
    class LaporanController
    {
        private LaporanContext Context = new LaporanContext();

        public List<Laporan> getAllLaporan()
        {
            return Context.getAllLaporan();
        }

        public bool TambahLaporan(Laporan laporan)
        {

            if (Validator.ApakahKosong(laporan.getIsiLaporan()))
            {
                MessageBox.Show("Isi laporan kosong", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            return Context.ADDLaporan(laporan);
        }

        public bool DeleteLaporan(int id)
        {
            bool isSucces = false;
            try
            {

                isSucces = Context.DelateLaporan(id);
            }
            catch
            {
                MessageBox.Show("gagal Hapus Laporan", "Peringatan Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSucces = false;
            }

            return isSucces;
        }
    }
}
