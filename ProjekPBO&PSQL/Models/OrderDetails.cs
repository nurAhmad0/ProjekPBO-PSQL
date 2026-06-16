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
        private string namaTanaman;

        public OrderDetails(int IDOrderDetails, decimal Harga, decimal JumlahOrder, int idOrder, int IDTanaman, string namatanaman)
        {
            this.IDOrderDetails = IDOrderDetails;
            this.Harga = Harga;
            this.JumlahOrder = JumlahOrder;
            this.idOrder = idOrder;
            this.IDTanaman = IDTanaman;
            this.namaTanaman = namatanaman;
        }

        public int getIDOrderDetails()
        {
            return this.IDOrderDetails;
        }
        public string getNamaTanaman()
        {
            return this.namaTanaman;
        }

        public decimal getHarga()
        {
            return this.Harga;
        }

        public decimal getJumlahOrder()
        {
            return this.JumlahOrder;
        }

        public int getIDOrder()
        {
            return this.idOrder;
        }

        public int getIDTanaman()
        {
            return this.IDTanaman;
        }
    }
}
