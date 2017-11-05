using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels.DTOs
{
    public class ProductTypeDTO
    {
        private int iD;
        private string description;

        public ProductTypeDTO()
        {

        }

        public ProductTypeDTO(int IDParam, string DescriptionParam)
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
