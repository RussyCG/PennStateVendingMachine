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
    public enum InsertableTables
    {
        Product, Country, Profile, Session
    }

    /// <summary>
    /// Lists what tables may have data be deleted from them
    /// </summary>
    public enum DeleteableTables
    {
        Product, Country, Session
    }

    /// <summary>
    /// Lists what tables may have data that can be updated at some point
    /// </summary>
    public enum UpdateableTables
    {
        Product, Country, Profile
    }

    /// <summary>
    /// Lists the views that can be selected by the application
    /// </summary>
    public enum SelectableViews
    {
        Product, Country, Role, Profile, User, Session
    }

    public enum SelectableViewsWithParameters
    {

    }
}
