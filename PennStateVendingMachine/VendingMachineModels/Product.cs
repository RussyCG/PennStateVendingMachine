using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class Product
    {
        private int iD;
        private string name;
        private ProductType productType;

        public Product()
        {

        }

        public Product(int IDParam, string NameParam, ProductType ProductTypeParam)
        {
            this.ID = IDParam;
            this.Name = NameParam;
            this.ProductType = ProductTypeParam;
        }

        public ProductType ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
