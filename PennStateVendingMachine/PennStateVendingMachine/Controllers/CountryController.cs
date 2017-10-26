using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PennStateVendingMachine.Controllers
{
    public class CountryController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new VendingMachineControllers.CountryController().GetAllCountries());
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "An internal error has occured. Please contact the system admin for advice");
            }
        }
    }
}
