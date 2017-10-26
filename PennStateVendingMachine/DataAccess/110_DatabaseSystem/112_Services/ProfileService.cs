using DataAccess._110_DatabaseSystem._111_Models;
using DataAccess._110_DatabaseSystem._113_Enums;
using DataAccess._110_DatabaseSystem._117_Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._112_Services
{
    public class ProfileService : BaseService.BaseService
    {
        public ProfileService()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            base.selectView = SelectableViews.Profile;
        }

        public List<Profile> SelectAll()
        {
            return base.Select(selectView).ToProfilesWithoutRoles();
        }
    }
}
