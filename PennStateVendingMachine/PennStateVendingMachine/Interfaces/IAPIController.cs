using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using VendingMachineModels.Connection;
using VendingMachineModels.DTOs;

namespace PennStateVendingMachine.Interfaces
{
    interface IAPIController
    {
        
        //HttpResponseMessage GetAll(VMRequest requestObj, RoleDTO methodRole);
        
        //HttpResponseMessage GetSingle(VMRequest requestObj, RoleDTO methodRole);
        [HttpPost]
        HttpResponseMessage RegisterNew(VMRequest requestObj, RoleDTO methodRole);
        [HttpPut]
        HttpResponseMessage Update(VMRequest requestObj, RoleDTO methodRole);
        [HttpDelete]
        HttpResponseMessage Delete(VMRequest requestObj, RoleDTO methodRole);
    }
}
