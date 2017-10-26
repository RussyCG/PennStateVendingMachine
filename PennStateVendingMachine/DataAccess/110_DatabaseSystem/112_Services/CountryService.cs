using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess._110_DatabaseSystem._111_Models;
using DataAccess._110_DatabaseSystem._117_Conversion;
using DataAccess._110_DatabaseSystem._113_Enums;

namespace DataAccess._110_DatabaseSystem._112_Services
{
    public class CountryService : BaseService.BaseService
    {
        public CountryService() : base()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {

            base.insertTable = InsertableTables.Country;
            base.deleteTable = DeleteableTables.Country;
            base.selectView = SelectableViews.Country;
            base.updateTable = UpdateableTables.Country;
        }

        public List<Country> SelectAll()
        {
            return base.Select(selectView).ToCountries();
        }
    }
}
