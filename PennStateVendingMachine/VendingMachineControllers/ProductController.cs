using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineModels;
using DTOConversion;
using DataAccess._110_DatabaseSystem._112_Services;
using DataAccess._110_DatabaseSystem._116_Common;

namespace VendingMachineControllers
{
    public class ProductController
    {
        public List<ProductDTO> GetAllProducts()
        {
            
            return new ProductService().Select().Convert();
        }

        public bool AddProduct()
        {

        }

        public bool UpdateProduct()
        {

        }

        public bool DeleteProduct()
        {

        }
    }
}
