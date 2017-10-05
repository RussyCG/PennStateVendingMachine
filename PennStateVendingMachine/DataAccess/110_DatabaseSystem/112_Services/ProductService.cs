using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess._110_DatabaseSystem._114_Interfaces.Services;
using DataAccess._110_DatabaseSystem._113_Enums;
using DataAccess._110_DatabaseSystem._111_Models;

namespace DataAccess._110_DatabaseSystem._112_Services
{
    public class ProductService : BaseService.BaseService//, IService
    {
        public ProductService() : base()
        {
            ProductService
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
            return base.Delete(deleteTable, ProductToDelete.GetIDParameters());
        }

        public bool Insert(Product ProductToInsert)
        {
            return base.Insert(insertTable, ProductToInsert.GetParameters());
        }

        public Product Select()
        {
            return base.Select(selectView);
        }

        public bool Update(Product ProductToUpdate)
        {
            return base.Update(updateTable, ProductToUpdate.GetParameters());
        }
    }
}
