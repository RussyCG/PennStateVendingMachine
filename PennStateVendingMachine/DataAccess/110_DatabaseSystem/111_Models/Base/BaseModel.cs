using DataAccess._110_DatabaseSystem._114_Interfaces.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess._110_DatabaseSystem._111_Models.Base
{
    /// <summary>
    /// Base Model for the models. Implements the GetParameters function
    /// </summary>
    public abstract class BaseModel : IBaseModel
    {
        /// <summary>
        /// Method to return all the parameter values for an object
        /// </summary>
        /// <param name="ParameteredObject">Object to get the parameters from</param>
        /// <returns>Parameters for the sql statement</returns>
        public virtual Dictionary<string, object> GetParameters(object ParameteredObject)
        {
            Dictionary<string, object> temp = new Dictionary<string, object>();
            foreach (var property in ParameteredObject.GetType().GetProperties())
            {
                temp.Add("@" + property.Name, property.GetValue(ParameteredObject, null));
            }
            return temp;
        }

        Dictionary<string, object> IBaseModel.GetParameters(object ParameteredObject)
        {
            throw new NotImplementedException();
        }
    }
}
