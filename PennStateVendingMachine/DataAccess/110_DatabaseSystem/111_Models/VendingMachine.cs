using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class VendingMachine
    {
        private int iD;
        private string serialNumber;
        private Branch branch;
        private Address address;

        public VendingMachine()
        {

        }

        public VendingMachine(int IDParam, string SerialNumberParam, Branch BranchParam, Address AddressParam)
        {
            this.ID = IDParam;
            this.SerialNumber = SerialNumberParam;
            this.Branch = BranchParam;
            this.Address = AddressParam;
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public Branch Branch
        {
            get { return branch; }
            set { branch = value; }
        }

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
