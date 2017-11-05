using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels.DTOs
{
    public class BranchDTO
    {
        private int iD;
        private string name;
        private CompanyDTO company;
        private AddressDTO address;
        private List<UserDTO> users;
        
        public BranchDTO()
        {

        }

        public BranchDTO(int IDParam, string NameParam, CompanyDTO CompanyParam, AddressDTO AddressParam, List<UserDTO> UsersParam)
        {
            this.ID = IDParam;
            this.Name = NameParam;
            this.Company = CompanyParam;
            this.Address = AddressParam;
            this.Users = UsersParam;
        }

        public List<UserDTO> Users
        {
            get { return users; }
            set { users = value; }
        }

        public AddressDTO Address
        {
            get { return address; }
            set { address = value; }
        }

        public CompanyDTO Company
        {
            get { return company; }
            set { company = value; }
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
