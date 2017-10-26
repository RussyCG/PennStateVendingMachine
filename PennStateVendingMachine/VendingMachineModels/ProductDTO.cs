using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class ProductDTO
    {
        private int iD;
        private string name;
        private ProductTypeDTO productType;

        public ProductDTO()
        {

        }

        public ProductDTO(int IDParam, string NameParam, ProductTypeDTO ProductTypeParam)
        {
            this.ID = IDParam;
            this.Name = NameParam;
            this.ProductType = ProductTypeParam;
        }

        public ProductTypeDTO ProductType
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
