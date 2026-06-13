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
        private Order OrderData;

        public JadwalPengantaran(int idJadwal, DateTime tanggal, string keteranganKegiatan, int banyakAnggota, string status, string NamaPelanggan, string NO_TELP, string DetailAlamat, int idPelanggan, decimal totalUpah, Order orderData) : base(idJadwal, tanggal, keteranganKegiatan, "Pengantaran", banyakAnggota, status, totalUpah)
        {
            this.NamaPelanggan = NamaPelanggan;
            this.NO_TELP = NO_TELP;
            this.DetailAlamat = DetailAlamat;
            this.IDPelanggan = idPelanggan;
            this.OrderData = orderData;
        }

        public Order getOrderData()
        {
            return this.OrderData;
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

        public int getIDPelanggan()
        {
            return this.IDPelanggan;
        }
    }
}