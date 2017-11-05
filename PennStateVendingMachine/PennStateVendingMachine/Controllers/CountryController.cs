using PennStateVendingMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VendingMachineControllers.Interfaces;
using VendingMachineModels.Connection;
using VendingMachineModels.DTOs;

namespace PennStateVendingMachine.Controllers
{
    public class CountryController : Base.BaseController
    {
        IController controller = new VendingMachineControllers.CountryController();

        public CountryController() : base()
        {
            base.Controller = controller;
        }

        [HttpGet]
        public HttpResponseMessage GetSingle(VMRequest requestObj)
        {
            RoleDTO role = new RoleDTO(1, "MyGet");
            return base.GetAll(requestObj, role);
        }
    }
}
