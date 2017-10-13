using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class ProfileDTO
    {
        private int iD;
        private string name;
        private List<RoleDTO> roles;
        
        public ProfileDTO()
        {

        }

        public ProfileDTO(int IDParam, string NameParam, List<RoleDTO> RolesParam)
        {
            this.ID = IDParam;
            this.Name = NameParam;
            this.Roles = RolesParam;
        }

        public List<RoleDTO> Roles
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
