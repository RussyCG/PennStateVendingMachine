using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class Country
    {
        public static string TableName = "Country";

        private int iD;
        private string name;

        public Country()
        {

        }

        public Country(int IDParam, string NameParam)
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
