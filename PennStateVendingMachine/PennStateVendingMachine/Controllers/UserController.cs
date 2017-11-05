using Exceptions;
using PennStateVendingMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VendingMachineModels;
using VendingMachineModels.Connection;
using VendingMachineModels.DTOs;

namespace PennStateVendingMachine.Controllers
{
    /// <summary>
    /// Responsible for all tasks relating to a user.
    /// </summary>
    public class UserController : Base.BaseController
    {
        #region Get

        /// <summary>
        /// Searches the database for a user with the specified User ID
        /// </summary>
        /// <param name="UserID">User ID to search with</param>
        /// <returns>UserDTO if found</returns>
        [HttpGet]
        public HttpResponseMessage GetUser(int UserID)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new VendingMachineControllers.UserController().GetUser(UserID));
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

        #region Post

        /// <summary>
        /// Registers a new user
        /// </summary>
        /// <param name="user">User details to register</param>
        /// <returns>HttpStatus OK if successfull</returns>
        [HttpPost]
        public HttpResponseMessage Register(UserDTO user)
        {
            throw new NotImplementedException("Register User has not yet been implemented on the WebAPI");
        }

        #endregion

        #region Put

        /// <summary>
        /// Updates the given user object in the database
        /// </summary>
        /// <param name="user">User values to update</param>
        /// <returns>HttpStatusCode OK if successful</returns>
        [HttpPut]
        public HttpResponseMessage Update(UserDTO user)
        {
            throw new NotImplementedException("Update User has not yet been implemented on the WebAPI");
        }

        #endregion

        #region Delete

        /// <summary>
        /// Removes the specified user from the database
        /// </summary>
        /// <param name="user">User to remove</param>
        /// <returns>HttpStatusCode OK if successfull</returns>
        [HttpDelete]
        public HttpResponseMessage Delete(UserDTO user)
        {
            throw new NotImplementedException("Delete User has not yet been implemented on the WebAPI");
        }

        public HttpResponseMessage GetAll(VMRequest requestObj, RoleDTO methodRole)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage GetSingle(VMRequest requestObj, RoleDTO methodRole)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage RegisterNew(VMRequest requestObj, RoleDTO methodRole)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage Update(VMRequest requestObj, RoleDTO methodRole)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage Delete(VMRequest requestObj, RoleDTO methodRole)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
