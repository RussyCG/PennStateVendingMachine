using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PennStateVendingMachine.Controllers
{
    /// <summary>
    /// Responsible for getting 
    /// </summary>
    public class ProfileController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetAllProfiles()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new VendingMachineControllers.ProfileController().GetAllProfiles());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetProfile(int ProfileID)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new VendingMachineControllers.ProfileController().GetAllProfiles());
            }
            catch (ElementNotFoundException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NoContent, ex.Message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
