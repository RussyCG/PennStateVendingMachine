using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PennStateVendingMachine.Controllers
{
    public class VendingMachineStatisticsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Connection Successful");
        }
    }
}
