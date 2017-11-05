using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess._110_DatabaseSystem._112_Services;
using DTOConversion;
using VendingMachineModels.DTOs.Base;
using VendingMachineControllers.Interfaces;

namespace VendingMachineControllers
{
    public class CountryController : IController
    {
        public BaseModel AddNew(BaseModel ModelToUpdate)
        {
            throw new NotImplementedException();
        }

        public BaseModel Delete(BaseModel RecordToRemove)
        {
            throw new NotImplementedException();
        }

        public List<BaseModel> GetAll()
        {
            return new CountryService().SelectAll().Select(x => x.ToDTO()).Select(x => (BaseModel)x).ToList();
        }

        public BaseModel GetSingle(BaseModel ID)
        {
            throw new NotImplementedException();
        }

        public BaseModel Update(BaseModel ModelToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
