using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class Role : Base.BaseModel
    {
        private int iD;
        private string name;

        public Role()
        {

        }

        public Role(int IDParam, string NameParam)
        {
            this.Name = NameParam;
            this.ID = IDParam;
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
