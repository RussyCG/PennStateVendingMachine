using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess._110_DatabaseSystem._114_Interfaces.Models.BaseModel
{
    /// <summary>
    /// Interface for the base model
    /// </summary>
    interface IBaseModel
    {
        /// <summary>
        /// Method that returns all the SQL Parameters for an object
        /// </summary>
        /// <param name="ParameteredObject">Object to get the parameters from</param>
        /// <returns>Dictionary of parameters</returns>
        Dictionary<string, object> GetParameters(object ParameteredObject);
    }
}
