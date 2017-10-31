using PennStateVendingMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using VendingMachineModels.Base;

namespace PennStateVendingMachine.Controllers.Base
{
    public abstract class BaseController : IAPIController
    {
        private Type ModelType;

        public BaseController(Type ModelTypeParam, IController controller)
        {
            this.ModelType = ModelTypeParam;
        }

        public HttpResponseMessage Delete(BaseModel model)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage GetAll()
        {
            
        }

        public HttpResponseMessage GetSingle(BaseModel model)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage RegisterNew(BaseModel model)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage Update(BaseModel model)
        {
            throw new NotImplementedException();
        }
    }
}