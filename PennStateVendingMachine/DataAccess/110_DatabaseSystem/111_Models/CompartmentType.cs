using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class CompartmentType
    {
        private int iD;
        private string description;

        public CompartmentType()
        {

        }

        public CompartmentType(int IDParam, string DescriptionParam)
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
