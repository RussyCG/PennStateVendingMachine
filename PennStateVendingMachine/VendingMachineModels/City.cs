using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class City
    {
        private int iD;
        private string name;

        public City()
        {

        }

        public City(int IDParam, string NameParam)
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
