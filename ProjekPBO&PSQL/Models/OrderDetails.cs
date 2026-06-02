using System;
using System.Collections.Generic;
using System.Text;

namespace ProjekPBO_PSQL.Models
{
    class OrderDetails
    {
        private int IDOrderDetails;
        private decimal Harga;
        private decimal JumlahOrder;
        private int idOrder;
        private int IDTanaman;

        public OrderDetails(int IDOrderDetails, decimal Harga, decimal JumlahOrder, int idOrder, int IDTanaman)
        {
            this.IDOrderDetails = IDOrderDetails;
            this.Harga = Harga;
            this.JumlahOrder = JumlahOrder;
            this.idOrder = idOrder;
            this.IDTanaman = IDTanaman;
        }

        public int getIDOrderDetails()
        {
            return this.IDOrderDetails;
        }

        public decimal getHarga()
        {
            return this.Harga;
        }

        public decimal getJumlahOrder()
        {
            return this.JumlahOrder;
        }

        private int getIDOrder()
        {
            return this.idOrder;
        }

        public int getIDTanaman()
        {
            return this.IDTanaman;
        }
    }
}
