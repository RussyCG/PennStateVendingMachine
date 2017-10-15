using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess._110_DatabaseSystem._114_Interfaces.Services;
using DataAccess._110_DatabaseSystem._113_Enums;
using DataAccess._110_DatabaseSystem._111_Models;
using DataAccess._110_DatabaseSystem._117_Conversion;

namespace DataAccess._110_DatabaseSystem._112_Services
{
    public class ProductService : BaseService.BaseService//, IService
    {
        public ProductService() : base()
        {
            
        }
        
        private void InitializeComponents()
        {
            
            base.insertTable = InsertableTables.Product;
            base.deleteTable = DeleteableTables.Product;
            base.selectView = SelectableViews.Product;
            base.updateTable = UpdateableTables.Product;
        }

        public bool Delete(Product ProductToDelete)
        {
            throw new NotImplementedException();
            //return base.Delete(deleteTable, ProductToDelete.GetIDParameters(ProductToDelete));
        }

        public bool Insert(Product ProductToInsert)
        {
            return base.Insert(insertTable, ProductToInsert.GetParameters(ProductToInsert));
        }

        public Product Select()
        {
            DataTable dt = base.Select(selectView);

            if (dt.Rows.Count <= 0 || dt.Rows == null)
                return null;

            return dt.Rows[0].ToProduct();
        }

        public List<Product> SelectAll()
        {
            return base.Select(selectView).ToProducts();
        }

        public bool Update(Product ProductToUpdate)
        {
            return base.Update(updateTable, ProductToUpdate.GetParameters(ProductToUpdate));
        }
    }
}
