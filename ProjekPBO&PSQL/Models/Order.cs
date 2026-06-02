using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class Order
    {
        private int IDOrder;
        private DateTime TanggalOrder;
        private int IDAnggota;
        private int IDPelanggan;
        private List<OrderDetails> listOrderdetails;

        public Order (int IDOrder, DateTime TanggalOrder, int IDAnggota, int IDPelanggan)
        {
            this.IDOrder = IDOrder;
            this.TanggalOrder = TanggalOrder;
            this.IDAnggota = IDAnggota;
            this.IDPelanggan = IDPelanggan;
            this.listOrderdetails = new List<OrderDetails>();
        }

        public int getIDOrder()
        {
            return this.IDOrder;
        }

        public DateTime getTanggalOrder()
        {
            return this.TanggalOrder;
        }

        public int getIdAnggota()
        {
            return this.IDAnggota;
        }

        public int getIDPelanggan()
        {
            return this.IDPelanggan;
        }

        public List<OrderDetails> getlistOrderdetails()
        {
            return this.listOrderdetails;
        }
    }
}
