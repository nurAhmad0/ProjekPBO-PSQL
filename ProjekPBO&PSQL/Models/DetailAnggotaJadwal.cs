using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class DetailAnggotaJadwal
    {
        private int IdAnggota;
        private string NamaAnggota;
        private DateTime WaktuJoin;
        private decimal upahDiterima;

        public DetailAnggotaJadwal(int id, string nama,  DateTime waktuJoin, decimal upahDiterima)
        {
            IdAnggota = id;
            NamaAnggota = nama;
            WaktuJoin = waktuJoin;
            this.upahDiterima = upahDiterima;
        }

        public int getIdAnggota()
        {
            return this.IdAnggota;
        }

        public string getNamaAnggota()
        {
            return this.NamaAnggota;
        }


        public DateTime getWaktuJoin()
        {
            return this.WaktuJoin;
        }

        public decimal getUpahDiterima()
        {
            return this.upahDiterima;
        }
    }
}
