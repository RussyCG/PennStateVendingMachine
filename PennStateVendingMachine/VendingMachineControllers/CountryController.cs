using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModels;
using DataAccess._110_DatabaseSystem._112_Services;
using DTOConversion;
using VendingMachineModelsv2.Interfaces;

namespace VendingMachineControllers
{
    public class CountryController
    {
        public List<IModelDTO> GetAll()
        {
            return new CountryService().SelectAll().Select(x => x.ToDTO()).ToList();
        }
    }
}
