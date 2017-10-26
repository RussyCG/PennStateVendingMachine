using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class CompartmentDTO
    {
        private int iD;
        private string description;
        private int capacity;
        private CompartmentTypeDTO compartmentType;

        public CompartmentDTO()
        {

        }

        public CompartmentDTO(int IDParam, string DescriptionParam, int CapacityParam, CompartmentTypeDTO CompartmentTypeParam)
        {
            this.ID = IDParam;
            this.Description = DescriptionParam;
            this.Capacity = CapacityParam;
            this.CompartmentType = CompartmentTypeParam;
        }

        public CompartmentTypeDTO CompartmentType
        {
            get { return compartmentType; }
            set { compartmentType = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
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
