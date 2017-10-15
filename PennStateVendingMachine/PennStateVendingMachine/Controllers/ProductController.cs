using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VendingMachineControllers;

namespace PennStateVendingMachine.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new VendingMachineControllers.ProductController().GetAllProducts());
        }
    }
}
