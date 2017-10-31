using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModelsv2.Interfaces;

namespace VendingMachineModels
{
    public class CountryDTO : IModelDTO
    {
        private int iD;
        private string name;

        public CountryDTO()
        {

        }

        public CountryDTO(int IDParam, string NameParam)
        {
            this.ID = IDParam;
            this.Name = NameParam;
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
