using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModels.DTOs;
using DataAccess._110_DatabaseSystem._112_Services;
using DTOConversion;

namespace VendingMachineControllers
{
    public class ProductController
    {
        public List<ProductDTO> GetAllProducts()
        {
            return new ProductService().SelectAll().Select(x => x.ToDTO()).ToList();
        }
    }
}
