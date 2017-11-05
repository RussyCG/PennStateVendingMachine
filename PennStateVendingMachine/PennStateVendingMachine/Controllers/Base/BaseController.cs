using PennStateVendingMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using VendingMachineModels.DTOs.Base;
using VendingMachineControllers.Interfaces;
using System.Net;
using System.Web.Http;
using VendingMachineModels;
using VendingMachineModels.Connection;
using SecurityFramework.Exceptions;
using VendingMachineModels.DTOs;

namespace PennStateVendingMachine.Controllers.Base
{
    public abstract class BaseController : ApiController, IAPIController
    {
        public IController Controller;

        public BaseController()
        {
        }
        
        protected HttpResponseMessage GetAll(VMRequest requestObj, RoleDTO methodRole)
        {
            return Condomize(Controller.GetAll, methodRole, requestObj);
        }

        protected HttpResponseMessage GetSingle(VMRequest requestObj, RoleDTO methodRole)
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

        #region Error Handling

        private HttpResponseMessage Condomize(Func<List<BaseModel>> nonProtectedAction, RoleDTO MethodRole, VMRequest RequestObj = null)
        {
            try
            {
                Authorise(RequestObj, MethodRole);

                return Request.CreateResponse(HttpStatusCode.OK, nonProtectedAction());
            }
            catch (InvalidSessionException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Forbidden, "Invalid Session information. Please log in to utilise this functionality");
            }
            catch (InvalidRequestFormatException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "The server recieved a corrupt or incomplete Request. Please try again");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "An internal error has occured. Please contact the system admin for advice");
            }
        }
        
        #endregion

        #region Authentication

        private HttpResponseMessage Authorise(VMRequest requestObj, RoleDTO methodRole)
        {
            if (isRequestFormatValid(requestObj))
            {
                if (new SecurityFramework.Authorization().isAuthorizedAction(requestObj.SessionID, methodRole))
                {
                    throw new InvalidSessionException();
                }
            }
            return new HttpResponseMessage();
        }
        
        #endregion

        #region Validation

        public bool isRequestFormatValid(VMRequest vmRequest)
        {
            if (vmRequest == null)
            {
                throw new InvalidRequestFormatException("Request is null");
            }

            if (vmRequest.SessionID != null)
            {
                if (vmRequest.SessionID != null && (vmRequest.ID != null || vmRequest.DecisionModel != null))
                {
                    return true;
                }
                throw new InvalidRequestFormatException();
            }
            else
            {
                throw new InvalidSessionException();
            }
        }

        #endregion
    }
}