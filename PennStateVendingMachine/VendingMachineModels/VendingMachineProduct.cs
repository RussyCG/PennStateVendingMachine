using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class VendingMachineProductDTO
    {
        private VendingMachineDTO vendingMachine;
        private CompartmentDTO compartment;
        private ProductDTO product;
        private double cost;
        private int stockOnHand;

        public VendingMachineProductDTO()
        {

        }

        public VendingMachineProductDTO(VendingMachineDTO VendingMachineParam, CompartmentDTO CompartmentParam, ProductDTO ProductParam, double CostParam, int StockOnHandParam)
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

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public ProductDTO Product
        {
            get { return product; }
            set { product = value; }
        }

        public CompartmentDTO Compartment
        {
            get { return compartment; }
            set { compartment = value; }
        }

        public VendingMachineDTO VendingMachine
        {
            get { return vendingMachine; }
            set { vendingMachine = value; }
        }

    }
}
