using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using VendingMachineModels.Base;

namespace PennStateVendingMachine.Interfaces
{
    interface IAPIController
    {
        [HttpGet]
        HttpResponseMessage GetAll();
        [HttpGet]
        HttpResponseMessage GetSingle(BaseModel model);
        [HttpPost]
        HttpResponseMessage RegisterNew(BaseModel model);
        [HttpPut]
        HttpResponseMessage Update(BaseModel model);
        [HttpDelete]
        HttpResponseMessage Delete(BaseModel model);
    }
}
