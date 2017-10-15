using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class Profile
    {
        public static string TableName = "Profile";

        private int iD;
        private string name;
        private List<Role> roles;
        
        public Profile()
        {

        }

        public Profile(int IDParam, string NameParam, List<Role> RolesParam)
        {
            this.ID = IDParam;
            this.Name = NameParam;
            this.Roles = RolesParam;
        }

        public List<Role> Roles
        {
            get { return roles; }
            set { roles = value; }
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
