using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class VendingMachinePurchase
    {
        private int iD;
        private VendingMachine vendingMachine;
        private Product product;
        private int cost;
        private int quantity;
        private DateTime dateTimePurchase;

        public VendingMachinePurchase()
        {

        }

        public VendingMachinePurchase(int IDParam, VendingMachine VendingMachineParam, Product ProductParam, int CostParam, int QuantityParam, DateTime DateTimePurchasedParam)
        {
            this.ID = IDParam;
            this.VendingMachine = VendingMachineParam;
            this.Product = ProductParam;
            this.Cost = CostParam;
            this.Quantity = QuantityParam;
            this.DateTimePurchased = DateTimePurchasedParam;
        }

        public DateTime DateTimePurchased
        {
            get { return dateTimePurchase; }
            set { dateTimePurchase = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public VendingMachine VendingMachine
        {
            get { return vendingMachine; }
            set { vendingMachine = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
