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

        public List<Laporan> getAllLaporanHariIni()
        {
            List<Laporan> DataLaporan = new List<Laporan>();
            List<Laporan> laporan = Context.getAllLaporan();

            DateTime TanggalSekarang = DateTime.Today;

            foreach (var L in laporan)
            {

                if (L.getWaktuLapor().Date == TanggalSekarang)
                {
                    DataLaporan.Add(L);
                }
            }

            return DataLaporan;
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
