using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Stores the information used by the enums for the Database System to function
/// </summary>
namespace DataAccess._110_DatabaseSystem._113_Enums
{
    /// <summary>
    /// Lists what tables may have data inserted into them by the application
    /// </summary>
    internal enum InsertableTables
    {
        Product
    }

    /// <summary>
    /// Lists what tables may have data be deleted from them
    /// </summary>
    internal enum DeleteableTables
    {
        Product
    }

    /// <summary>
    /// Lists what tables may have data that can be updated at some point
    /// </summary>
    internal enum UpdateableTables
    {
        Product
    }

    /// <summary>
    /// Lists the views that can be selected by the application
    /// </summary>
    internal enum SelectableViews
    {
        Product
    }

    internal enum SelectableViewsWithParameters
    {

    }
}
