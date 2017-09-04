using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccess._110_DatabaseSystem._113_Enums;
using DataAccess._110_DatabaseSystem._114_Interfaces.Services.BaseService;

namespace DataAccess._110_DatabaseSystem._112_Services.BaseService
{
    /// <summary>
    /// Base class that all Database System Services must use
    /// </summary>
    class BaseService : IBaseService, IDisposable
    {
        #region Fields

        #endregion

        #region Constructors

        public BaseService()
        {

        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        #region Database Methods

        public DataTable Select(SelectableViews ViewToSelect)
        {
            throw new NotImplementedException();
        }

        public DataTable Select(SelectableViewsWithParameters ViewToSelect, Dictionary<string, object> Parameters)
        {
            throw new NotImplementedException();
        }

        public bool Insert(InsertableTables TableToInsertInto, Dictionary<string, object> Parameters)
        {
            throw new NotImplementedException();
        }

        public bool Update(UpdateableTables TableToUpdateFrom, Dictionary<string, object> Parameters, string ObjectID)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DeleteableTables TableToDeleteFrom, string ID)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Interface implementation

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
        #endregion

        #endregion
    }
}
