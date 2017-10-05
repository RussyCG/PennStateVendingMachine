using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess._110_DatabaseSystem._111_Models;
using VendingMachineModels;

namespace DTOConversion
{
    public static class DTOConversion
    {
        public static ProductDTO Convert(this Product product)
        {
            return new ProductDTO()
            {
                ProductID = product.ProductID,
                ProductDescription = product.ProductDescription
            };
        }

        public static Product Convert(this ProductDTO product)
        {
            return new Product()
            {
                ProductID = product.ProductID,
                ProductDescription = product.ProductDescription
            };
        }
    }
}
