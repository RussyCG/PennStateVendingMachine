using DataAccess._110_DatabaseSystem._114_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class ProductType : IModel
    {
        private int iD;
        private string description;

        public ProductType()
        {

        }

        public ProductType(int IDParam, string DescriptionParam)
        {
            this.ID = IDParam;
            this.Descripton = DescriptionParam;
        }

        public string Descripton
        {
            get { return description; }
            set { description = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public Dictionary<string, object> GetParameters(object ParameteredObject)
        {
            throw new NotImplementedException();
        }
    }
}
