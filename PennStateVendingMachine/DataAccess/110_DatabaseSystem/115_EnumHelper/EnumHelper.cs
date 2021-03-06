﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccess._110_DatabaseSystem._113_Enums;

namespace DataAccess._110_DatabaseSystem._115_EnumHelper
{
    /// <summary>
    /// Class to convert enum list to string of view and stored procedure name
    /// </summary>
    static class EnumHelper
    {
        /// <summary>
        /// Method to convert InsertableTables Enum to the string of the stored procedure name
        /// </summary>
        /// <param name="TableToInsertTo">Enum value selected</param>
        /// <returns>String name of Stored Procedure in database</returns>
        internal static string GetStoredProcedureName(InsertableTables TableToInsertTo)
        {
            string temp = "sp_Insert";

            // Insert switch here to dictate table names

            return temp;
        }

        /// <summary>
        /// Method to convert UpdateableTables Enum to the string of the stored procedure name
        /// </summary>
        /// <param name="TableToUpdateTo">Enum Value selected</param>
        /// <returns>String name of Stored Procedure in Database</returns>
        internal static string GetStoredProcedureName(UpdateableTables TableToUpdateTo)
        {
            string temp = "sp_Update";

            // Insert switch to set table name

            return temp;
        }

        /// <summary>
        /// Method to convert DeleteableTables Enum to the string of the stored procedure name
        /// </summary>
        /// <param name="TableToDeleteFrom">Enum Value selected</param>
        /// <returns>String name of the Stored Procedure in database</returns>
        internal static string GetStoredProcedureName(DeleteableTables TableToDeleteFrom)
        {
            string temp = "sp_Delete";

            // Insert switch to set table name

            return temp;
        }

        /// <summary>
        /// Method to convert SelectableViews Enum to the string of the view name
        /// </summary>
        /// <param name="TableToSelectFrom">Enum Value selected</param>
        /// <returns>String name of the view in Database</returns>
        internal static string GetViewName(SelectableViews TableToSelectFrom)
        {
            string temp = "view_";

            switch (TableToSelectFrom)
            {
                case SelectableViews.Product:
                    break;
                case SelectableViews.Country:
                    return temp + "Country";
                case SelectableViews.Role:
                    return temp + "Role";
                case SelectableViews.Profile:
                    return temp + "Profile";
                case SelectableViews.User:
                    return temp + "User";
                case SelectableViews.Session:
                    return temp + "Session";
                default:
                    break;
            }

            return temp;
        }

        /// <summary>
        /// Method to convert SelectableViewsWithParameters Enum to the string of the view name
        /// </summary>
        /// <param name="TableToSelectFrom">Enum Value selected</param>
        /// <returns>String name of the view in database</returns>
        internal static string GetViewName(SelectableViewsWithParameters TableToSelectFrom)
        {
            string temp = "view_";

            // Insert switch to set view name

            return temp;
        }
    }
}
