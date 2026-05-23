using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class JadwalPengantaran : Jadwal
    {
        private string NamaPelanggan;
        private string NO_TELP;
        private string DetailAlamat;
        private int OderID;
        private DateTime TanggalOrder;
        private decimal JumlahPoduk;
        private decimal Harga;

        public JadwalPengantaran(int idJadwal, DateTime tanggal, string keteranganKegiatan, int banyakAnggota, List<int> iDAnggota, List<string> namaAnggota, string status, string NamaPelanggan, string NO_TELP, string DetailAlamat, int OrderID, DateTime TanggalOrder, decimal JumlahProduk, decimal Harga) : base (idJadwal, tanggal, keteranganKegiatan, "Pengantaran", banyakAnggota, iDAnggota, namaAnggota, status)
        {
            this.NamaPelanggan = NamaPelanggan;
            this.NO_TELP = NO_TELP;
            this.DetailAlamat = DetailAlamat;
            this.OderID = OrderID;
            this.TanggalOrder = TanggalOrder;
            this.JumlahPoduk = JumlahProduk;
            this.Harga = Harga;
        }

        public string getNamaPelanggan()
        {
            return this.NamaPelanggan;
        }

        public string getNO_TELP()
        {
            return this.NO_TELP;
        }

        public string getDetailAlamat()
        {
            return this.DetailAlamat;
        }

        public int getOderID()
        {
            return this.OderID;
        }

        public DateTime getTanggalOrder()
        {
            return this.TanggalOrder;
        }

        public decimal getJumlahProduk()
        {
            return JumlahPoduk;
        }

        public decimal getHarga()
        {
            return Harga;
        }
    }
}
