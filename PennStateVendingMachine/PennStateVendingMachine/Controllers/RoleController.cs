using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Exceptions;

namespace PennStateVendingMachine.Controllers
{
    /// <summary>
    /// Responsible for getting and maniulate role data
    /// </summary>
    public class RoleController : ApiController
    {
        #region Get

        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new VendingMachineControllers.RoleController().GetAllRoles());
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        public HttpResponseMessage Get(int RoleID)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new VendingMachineControllers.RoleController().GetRole(RoleID));
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

        #endregion

        // There is no other methods as roles are set by the system and dictate what a user can and can't do
        // Thus a user cannot modify them.
    }
}
