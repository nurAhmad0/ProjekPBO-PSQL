using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class JadwalPengantaran : Jadwal
    {
        private int IDPelanggan;
        private string NamaPelanggan;
        private string NO_TELP;
        private string DetailAlamat;
        private int OrderID;
        private DateTime TanggalOrder;
        private decimal JumlahProduk;
        private decimal Harga;
        private string namaTanaman;

        public JadwalPengantaran(int idJadwal, DateTime tanggal, string keteranganKegiatan, int banyakAnggota, List<int> iDAnggota, List<string> namaAnggota, string status, List<string> StatusAnggota, List<DateTime> WaktuJoin, string NamaPelanggan, string NO_TELP, string DetailAlamat, int OrderID, DateTime TanggalOrder, decimal JumlahProduk, decimal Harga, string namaTanaman, int idPelanggan) : base (idJadwal, tanggal, keteranganKegiatan, "Pengantaran", banyakAnggota, iDAnggota, namaAnggota, status, StatusAnggota, WaktuJoin)
        {
            this.NamaPelanggan = NamaPelanggan;
            this.NO_TELP = NO_TELP;
            this.DetailAlamat = DetailAlamat;
            this.OrderID = OrderID;
            this.TanggalOrder = TanggalOrder;
            this.JumlahProduk = JumlahProduk;
            this.Harga = Harga;
            this.namaTanaman = namaTanaman;
            this.IDPelanggan = idPelanggan;
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
            return this.OrderID;
        }

        public DateTime getTanggalOrder()
        {
            return this.TanggalOrder;
        }

        public decimal getJumlahProduk()
        {
            return this.JumlahProduk;
        }

        public decimal getHarga()
        {
            return this.Harga;
        }

        public string getNamaTanaman()
        {
            return this.namaTanaman;
        }

        public int getIDPelanggan()
        {
            return this.IDPelanggan;
        }
    }
}
