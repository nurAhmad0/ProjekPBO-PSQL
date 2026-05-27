using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class JadwalFarmer : Jadwal
    {
        private int IDLahan;
        private string NamaLahan;
        private string NamaTanaman;
        private DateTime TanggalDitanam;
        private int JumlahDitanam;


        public JadwalFarmer(int idJadwal, DateTime tanggal, string keteranganKegiatan, int banyakAnggota, List<int> iDAnggota, List<string> namaAnggota, string status, List<string> StatusAnggota, List<DateTime> WaktuJoin, string namaLahan, string namaTanaman, DateTime tanggalDitanam, int jumlahDitanam, int idLahan) : base (idJadwal, tanggal, keteranganKegiatan, "Farmer", banyakAnggota, iDAnggota, namaAnggota, status, StatusAnggota, WaktuJoin)
        {
            this.NamaLahan = namaLahan;
            this.NamaTanaman = namaTanaman;
            this.TanggalDitanam = tanggalDitanam;
            this.JumlahDitanam = jumlahDitanam;
            this.IDLahan = idLahan;
        }

        public string getNamaLahan()
        {
            return this.NamaLahan;
        }
        public int getIDLahan()
        {
            return this.IDLahan;
        }

        public string getNamaTanaman()
        {
            return this.NamaTanaman;
        }

        public DateTime getTanggalDitanam()
        {  
            return this.TanggalDitanam;
        }

        public int getJumlahDitanam()
        {
            return this.JumlahDitanam;
        }

        public void setNamaLahan(string namaLahan)
        {
            this.NamaLahan =namaLahan;
        }

        public void setNamaTanaman(string namaTanaman)
        {
            this.NamaTanaman = namaTanaman;
        }

        public void setTanggalDitanam(DateTime tanggalDitanam)
        {
            this.TanggalDitanam = tanggalDitanam;
        }

        public void setJumlahDitanam(int jumlahDitanam)
        {
            this.JumlahDitanam = jumlahDitanam;
        }
    }
}
