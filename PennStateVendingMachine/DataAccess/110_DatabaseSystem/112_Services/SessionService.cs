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
    public class SessionService : BaseService.BaseService
    {
        public SessionService() : base()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            base.insertTable = InsertableTables.Session;
            base.deleteTable = DeleteableTables.Session;
            base.selectView = SelectableViews.Session;
        }

        public List<Session> SelectAll()
        {
            return base.Select(selectView).ToSessions();
        }

        public Session SelectOne(string ID)
        {
            return SelectAll().FirstOrDefault(x => x.ID == ID);
        }
    }
}
