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
    public class UserService: BaseService.BaseService
    {
        public UserService()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            base.selectView = SelectableViews.User;
        }

        public List<User> SelectAll()
        {
            return base.Select(selectView).ToUsers();
        }
    }
}
