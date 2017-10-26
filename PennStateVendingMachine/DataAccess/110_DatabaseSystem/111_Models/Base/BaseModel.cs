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
        public Dictionary<string, object> GetParameters(object ParameteredObject)
        {
            // Declare new Dictionary that will be used to store the parameter values
            Dictionary<string, object> temp = new Dictionary<string, object>();
            // Foreach property found in the selected class
            foreach (var property in ParameteredObject.GetType().GetProperties())
            {
                // Format the property name to be inline with parameter values for SQL
                // Add the new property name and value to the dictionary
                temp.Add("@" + property.Name, property.GetValue(ParameteredObject, null));
            }
            // Return the formatted parameter values
            return temp;
        }
    }
}
