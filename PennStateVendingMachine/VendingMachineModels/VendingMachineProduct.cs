using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class VendingMachineProduct
    {
        private VendingMachine vendingMachine;
        private Compartment compartment;
        private Product product;
        private int cost;
        private int stockOnHand;

        public VendingMachineProduct()
        {

        }

        public VendingMachineProduct(VendingMachine VendingMachineParam, Compartment CompartmentParam, Product ProductParam, int CostParam, int StockOnHandParam)
        {
            this.VendingMachine = VendingMachineParam;
            this.Compartment = CompartmentParam;
            this.Product = ProductParam;
            this.Cost = CostParam;
            this.StockOnHand = StockOnHandParam;
        }

        public int StockOnHand
        {
            get { return stockOnHand; }
            set { stockOnHand = value; }
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

        public Compartment Compartment
        {
            get { return compartment; }
            set { compartment = value; }
        }

        public VendingMachine VendingMachine
        {
            get { return vendingMachine; }
            set { vendingMachine = value; }
        }

    }
}
