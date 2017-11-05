using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class Session : Base.BaseModel
    {
        public static string TableName = "Session";

        private string iD;
        private User user;
        private DateTime logDateTime;

        public Session()
        {

        }

        public Session(string IDParam, User UserParam, DateTime LogDateTimeParam)
        {
            this.ID = IDParam;
            this.User = UserParam;
            this.LogDateTime = LogDateTimeParam;
        }

        public DateTime LogDateTime
        {
            get { return logDateTime; }
            set { logDateTime = value; }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
