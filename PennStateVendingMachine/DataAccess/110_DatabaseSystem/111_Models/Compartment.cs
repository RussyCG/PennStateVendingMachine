using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class Compartment
    {
        private int iD;
        private string description;
        private int capacity;
        private CompartmentType compartmentType;

        public Compartment()
        {

        }

        public Compartment(int IDParam, string DescriptionParam, int CapacityParam, CompartmentType CompartmentTypeParam)
        {
            this.ID = IDParam;
            this.Description = DescriptionParam;
            this.Capacity = CapacityParam;
            this.CompartmentType = CompartmentTypeParam;
        }

        public CompartmentType CompartmentType
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
