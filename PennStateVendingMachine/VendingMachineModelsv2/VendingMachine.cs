using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class VendingMachineDTO
    {
        private int iD;
        private string serialNumber;
        private BranchDTO branch;
        private Address address;

        public VendingMachineDTO()
        {

        }

        public VendingMachineDTO(int IDParam, string SerialNumberParam, BranchDTO BranchParam, Address AddressParam)
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

        public BranchDTO Branch
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
