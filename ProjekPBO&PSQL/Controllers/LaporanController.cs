using System;
using System.Collections.Generic;
using System.Text;
using ProjekPBO_PSQL.Models;
using System.Windows.Forms;

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
    }
}
