using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class DetailAnggotaJadwal
    {
        private int IdAnggota;
        private string NamaAnggota;
        private string StatusJadwalIndividu;
        private DateTime WaktuJoin;

        public DetailAnggotaJadwal(int id, string nama, string status, DateTime waktuJoin)
        {
            IdAnggota = id;
            NamaAnggota = nama;
            StatusJadwalIndividu = status;
            WaktuJoin = waktuJoin;
        }

        public int getIdAnggota()
        {
            return this.IdAnggota;
        }

        public string getNamaAnggota()
        {
            return this.NamaAnggota;
        }

        public string getStatusJadwal()
        {
            return this.StatusJadwalIndividu;
        }

        public DateTime getWaktuJoin()
        {
            return this.WaktuJoin;
        }
    }
}
