using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Laporan
    {

        private int idlaporan;
        private string isiLaporan;
        private DateTime WaktuLapor;
        private int idJadwal;
        private int idAnggota;
        private string keteranganKegiatan;
        private string namaAnggota;
        private DateTime TanggalJadwal;

        public Laporan(int idlaporan, string isiLaporan, DateTime waktuLapor, int idJadwal, int idAnggota, string keteranganKegiatan, string namaAnggota, DateTime tanggalJadwal)
        {
            this.idlaporan = idlaporan;
            this.isiLaporan = isiLaporan;
            WaktuLapor = waktuLapor;
            this.idJadwal = idJadwal;
            this.idAnggota = idAnggota;
            this.keteranganKegiatan = keteranganKegiatan;
            this.namaAnggota = namaAnggota;
            TanggalJadwal = tanggalJadwal;
        }

        public int getIdlaporan() 
        { 
            return this.idlaporan; 
        }

        public string getIsiLaporan()
        {
            return this.isiLaporan;
        }

        public DateTime getWaktuLapor() 
        {
            return this.WaktuLapor;
        }

        public int getidJadwal()
        {
            return this.idJadwal;
        }

        public int getIdAnggota()
        {
            return this.idAnggota;
        }

        public string getKeteranganKegiatan()
        {
            return this.keteranganKegiatan;
        }

        public string getNamaAnggota()
        {
            return this.namaAnggota;
        }

        public DateTime getTanggalJadwal()
        {
            return this.TanggalJadwal;
        }
    }
}
