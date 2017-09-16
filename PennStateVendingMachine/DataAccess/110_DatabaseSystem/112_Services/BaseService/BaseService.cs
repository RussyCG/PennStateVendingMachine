using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccess._110_DatabaseSystem._113_Enums;
using DataAccess._110_DatabaseSystem._114_Interfaces.Services.BaseService;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using DataAccess._110_DatabaseSystem._115_EnumHelper;

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

        //public BaseService()
        //{

        //}

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

        #region Select

        /// <summary>
        /// Performs a select statement on the view supplied
        /// </summary>
        /// <param name="ViewToSelect">View to select from</param>
        /// <returns>Result set returned from the database</returns>
        public DataTable Select(SelectableViews ViewToSelect)
        {
            // Set the command text to be executed on the database
            string cmdText = "Select * from " + EnumHelper.GetViewName(ViewToSelect);

            // Initialize the command
            command = InitializeCommand(cmdText, false);
            // Execute the command
            return PerformSelect(command);
        }

        /// <summary>
        /// Used to perform a select with parameters
        /// </summary>
        /// <param name="ViewToSelect">View in the database to select</param>
        /// <param name="Parameters">Parameters needed by the view</param>
        /// <returns>Resulting result set from the database</returns>
        public DataTable Select(SelectableViewsWithParameters ViewToSelect, Dictionary<string, object> Parameters)
        {
            // Set the command text that is used to execute the correct command
            string cmdText = EnumHelper.GetViewName(ViewToSelect);

            // Set the initilized command
            command = InitializeCommand(cmdText, false);
            // Set the command type to that of a stored procedure
            command.CommandType = CommandType.StoredProcedure;

            // Repeat for every parameter supplied
            foreach (string parameterName in Parameters.Keys)
            {
                // Add the parameters to the command
                command.Parameters.AddWithValue(parameterName, Parameters[parameterName]);
            }

            // Execute the command
            return PerformSelect(command);
        }

        /// <summary>
        /// Used to actually run the select command against the database
        /// </summary>
        /// <param name="cmd">Command object used to perform the select</param>
        /// <returns>Result set returned from the Database</returns>
        private DataTable PerformSelect(SqlCommand command)
        {
            // Executes the command to the database
            command.ExecuteNonQuery();

            // Initialize the DataTable
            dataTable = new DataTable();
            // Give the SqlAdapter the value returned from the command result
            adapter = new SqlDataAdapter(command);
            // Fill the DataTable with the information returned
            adapter.Fill(dataTable);
            // Return the Filled DataTable to the calling method
            return dataTable;
        }

        #endregion

        public bool Insert(InsertableTables TableToInsertInto, Dictionary<string, object> Parameters)
        {
            string procedureName = EnumHelper.GetStoredProcedureName(TableToInsertInto);

            command = InitializeCommand(procedureName, true);

            return PerformProcedure(command, Parameters);
        }

        public bool Update(UpdateableTables TableToUpdateFrom, Dictionary<string, object> Parameters)
        {
            string procedureName = EnumHelper.GetStoredProcedureName(TableToUpdateFrom);

            command = InitializeCommand(procedureName, true);

            return PerformProcedure(command, Parameters);
        }

        public bool Delete(DeleteableTables TableToDeleteFrom, Dictionary<string, object> IDwithName)
        {
            string procedureName = EnumHelper.GetStoredProcedureName(TableToDeleteFrom);

            command = InitializeCommand(procedureName, true);

            return PerformProcedure(command, IDwithName);
        }

        #region Command Methods

        /// <summary>
        /// Initializes the SqlCommand with the connection string
        /// </summary>
        /// <param name="cmdText">Command Text used to initialize the command</param>
        /// <returns>The initialized SqlCommand</returns>
        private SqlCommand InitializeCommand(string cmdText, bool isCommandTypeProcedure)
        {
            SqlCommand cmd = new SqlCommand(cmdText, new SqlConnection(connectionString));

            if (isCommandTypeProcedure)
                cmd.CommandType = CommandType.StoredProcedure;

            return cmd;

        }

        private bool PerformProcedure(SqlCommand command, Dictionary<string, object> Parameters)
        {
            foreach (string parameterName in Parameters.Keys)
            {
                command.Parameters.AddWithValue(parameterName, Parameters[parameterName]);
            }

            return ProcedureExecutedSuccessfully(command.ExecuteNonQuery());
        }

        /// <summary>
        /// Checks if the Stored Procedure was executed successfully onto the database
        /// </summary>
        /// <param name="RowsAffected">Number of Rows Affected by statements</param>
        /// <returns></returns>
        private bool ProcedureExecutedSuccessfully(int RowsAffected)
        {
            // If the number of rows affected by the stored procedure is greater than 1
            if (RowsAffected > 0)
                // Procedure executed successfully
                return true;
            // If the code reaches here then no rows where affected
            return false;
        }

        #endregion

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
