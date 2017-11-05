using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModels.DTOs.Base;

namespace VendingMachineControllers.Interfaces
{
    public interface IController
    {
        /// <summary>
        /// Returns all elements found in the database
        /// </summary>
        /// <returns>All models found</returns>
        List<BaseModel> GetAll();
        /// <summary>
        /// Searches the table for an ID matching that specified
        /// </summary>
        /// <param name="ID">ID to search for</param>
        /// <returns>Model Found, throws RecordNotFoundException if no record can be found</returns>
        BaseModel GetSingle(BaseModel ID);
        /// <summary>
        /// Removes the record with the specified ID from the DB
        /// </summary>
        /// <param name="RecordToRemove">Record to remove from the DB</param>
        /// <returns>True if the record was removed successfully</returns>
        BaseModel Delete(BaseModel RecordToRemove);
        /// <summary>
        /// Updates the details of a record in the DB
        /// </summary>
        /// <param name="ModelToUpdate">Model to be updated in the DB</param>
        /// <returns>True if the update was successful</returns>
        BaseModel Update(BaseModel ModelToUpdate);
        /// <summary>
        /// Creates a new record in the DB
        /// </summary>
        /// <param name="ModelToInsert">Model to be inserted into the DB</param>
        /// <returns>True if the add was successful</returns>
        BaseModel AddNew(BaseModel ModelToUpdate);
    }
}
