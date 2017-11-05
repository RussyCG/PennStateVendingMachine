using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels.DTOs
{
    public class SuburbDTO
    {
        private int iD;
        private string name;
        private string postalCode;

        public SuburbDTO()
        {

        }

        public SuburbDTO(int IDParam, string NameParam, string PostalCodeParam)
        {
            this.ID = IDParam;
            this.Name = NameParam;
            this.PostalCode = PostalCodeParam;
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
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
