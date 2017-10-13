using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class Branch
    {
        private int iD;
        private string name;
        private Company company;
        private Address address;
        private List<User> users;
        
        public Branch()
        {

        }

        public Branch(int IDParam, string NameParam, Company CompanyParam, Address AddressParam, List<User> UsersParam)
        {
            this.ID = IDParam;
            this.Name = NameParam;
            this.Company = CompanyParam;
            this.Address = AddressParam;
            this.Users = UsersParam;
        }

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public Company Company
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
