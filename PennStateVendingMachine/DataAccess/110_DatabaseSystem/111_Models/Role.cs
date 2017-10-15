using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class Role : Base.BaseModel
    {
        public static string TableName = "Role";

        private int iD;
        private string name;

        public Role()
        {

        }

        public Role(int IDParam, string NameParam)
        {
            this.Name = NameParam;
            this.ID = IDParam;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }


    }
}
