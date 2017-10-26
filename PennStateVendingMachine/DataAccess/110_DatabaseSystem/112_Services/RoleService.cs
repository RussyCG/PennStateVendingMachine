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
    public class RoleService : BaseService.BaseService
    {
        public RoleService()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            base.selectView = SelectableViews.Role;
        }

        public List<Role> SelectAll()
        {
            return base.Select(selectView).ToRoles();
        }
    }
}
