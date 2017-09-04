using System;
using System.Collections.Generic;
using System.Text;
using DataAccess._110_DatabaseSystem._114_Interfaces.Models.BaseModel;

namespace DataAccess._110_DatabaseSystem._114_Interfaces.Models
{
    /// <summary>
    /// Interface that needs to be inherited on all Model Objects
    /// </summary>
    interface IModel : IBaseModel
    {
        #region C# Base Methods

        /// <summary>
        /// String representation of the model
        /// </summary>
        /// <returns>Object in string format</returns>
        string ToString();

        /// <summary>
        /// Gets the unique hash code for the object
        /// </summary>
        /// <returns>Unique hash code</returns>
        int GetHashCode();

        /// <summary>
        /// Method used to compare objects together
        /// </summary>
        /// <param name="obj">Other object to compare the current object to</param>
        /// <returns>If the objects are the same</returns>
        bool Equals(object obj);

        #endregion
    }
}
