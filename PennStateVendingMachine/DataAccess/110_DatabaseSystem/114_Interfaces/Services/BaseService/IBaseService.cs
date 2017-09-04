using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using DataAccess._110_DatabaseSystem._113_Enums;

namespace DataAccess._110_DatabaseSystem._114_Interfaces.Services.BaseService
{
    /// <summary>
    /// BaseService Interface
    /// </summary>
    interface IBaseService
    {
        /// <summary>
        /// Select Method used to pull all data from a table
        /// </summary>
        /// <param name="ViewToSelect">View that will be called from the database</param>
        /// <returns>Data Returned from the database</returns>
        DataTable Select(SelectableViews ViewToSelect);

        /// <summary>
        /// Method used to select data from a table whilst restricting the result set with parameters
        /// </summary>
        /// <param name="ViewToSelect">View To Select</param>
        /// <param name="Parameters">Parameters that limit select</param>
        /// <returns>Data returned from the database</returns>
        DataTable Select(SelectableViewsWithParameters ViewToSelect, Dictionary<string, object> Parameters);

        /// <summary>
        /// Insert method to insert new data into the database
        /// </summary>
        /// <param name="TableToInsertInto">Table To insert the data into</param>
        /// <param name="Parameters">Parameters to insert into the table</param>
        /// <returns>if the data was correctly inserted into the specified table</returns>
        bool Insert(InsertableTables TableToInsertInto, Dictionary<string, object> Parameters);

        /// <summary>
        /// Update method that alters pre-existing data in the database
        /// </summary>
        /// <param name="TableToUpdateFrom">Table that has the value that needs to be updated</param>
        /// <param name="Parameters">Parameters that need to be updated</param>
        /// <param name="ObjectID">ObjectID that needs to be updated</param>
        /// <returns>If the data was successfully updated</returns>
        bool Update(UpdateableTables TableToUpdateFrom, Dictionary<string, object> Parameters, string ObjectID);

        /// <summary>
        /// Method to delete data from a table
        /// </summary>
        /// <param name="TableToDeleteFrom">Table to delete the data from</param>
        /// <param name="ID">Record ID that needs to be deleted</param>
        /// <returns>If the the data was successfully removed from the table</returns>
        bool Delete(DeleteableTables TableToDeleteFrom, string ID);
    }
}
