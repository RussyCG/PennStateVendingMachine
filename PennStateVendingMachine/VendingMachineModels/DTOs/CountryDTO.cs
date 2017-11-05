using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModels.DTOs.Interfaces;

namespace VendingMachineModels.DTOs
{
    public class CountryDTO : Base.BaseModel
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
