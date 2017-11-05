using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels.DTOs
{
    public class CompartmentTypeDTO
    {
        private int iD;
        private string description;

        public CompartmentTypeDTO()
        {

        }

        public CompartmentTypeDTO(int IDParam, string DescriptionParam)
        {
            this.ID = IDParam;
            this.Description = DescriptionParam;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
