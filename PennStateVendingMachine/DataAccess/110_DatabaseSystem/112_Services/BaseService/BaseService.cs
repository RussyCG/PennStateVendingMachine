using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccess._110_DatabaseSystem._113_Enums;
using DataAccess._110_DatabaseSystem._114_Interfaces.Services.BaseService;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess._110_DatabaseSystem._112_Services.BaseService
{
    /// <summary>
    /// Base class that all Database System Services must use
    /// </summary>
    class BaseService : IBaseService, IDisposable
    {
        #region Fields

        /// <summary>
        /// Dictates the command executed on the database
        /// </summary>
        SqlCommand command;
        /// <summary>
        /// Sets the connection to the database
        /// </summary>
        SqlConnection connection;
        /// <summary>
        /// Used to get data from the dataset
        /// </summary>
        SqlDataAdapter adapter;
        /// <summary>
        /// Used to store the result from the database
        /// </summary>
        DataTable dataTable;
        /// <summary>
        /// Sets the connection string to be used to connect to the database
        /// </summary>
        string connectionString;

        #endregion

        #region Constructors

        public BaseService()
        {

        }

        /// <summary>
        /// Sets the connection with the supplied ConnectionStringName
        /// </summary>
        /// <param name="ConnectionStringName">Name of the connection string to use from the .config file</param>
        public BaseService(string ConnectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString.ToString();
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
