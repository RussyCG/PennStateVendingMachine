using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    /// <summary>
    /// Representation of the Address Table from the database
    /// </summary>
    public class Address
    {
        // Table name from the Database
        public static string TableName = "Address";

        // ID of the specific Address
        private int iD;
        // Line 1 / Street Address
        private string streetAddress;
        // Suburb of the Address
        private Suburb suburb;
        // City of the Address
        private City city;
        // Province of the Address
        private Province province;
        // Country for the Address
        private Country country;

        /// <summary>
        /// Default constructor, used for serialization if needed
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Parametered Constructor
        /// </summary>
        /// <param name="IDParam">ID to assign to the Address</param>
        /// <param name="StreetAddressParam">Line 1 / Street Address to be assigned to the Address</param>
        /// <param name="SuburbParam">Suburb to be assigned to the Address</param>
        /// <param name="CityParam">City to be assigned to the Address</param>
        /// <param name="ProvinceParam">Province to be assigned to the Address</param>
        /// <param name="CountryParam">Country to be assigned to the Address</param>
        public Address(int IDParam, string StreetAddressParam, Suburb SuburbParam, City CityParam, Province ProvinceParam, Country CountryParam)
        {
            this.ID = IDParam;
            this.StreetAddress = StreetAddressParam;
            this.Suburb = SuburbParam;
            this.City = CityParam;
            this.Province = ProvinceParam;
            this.Country = CountryParam;
        }

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }

        public Province Province
        {
            get { return province; }
            set { province = value; }
        }

        public City City
        {
            get { return city; }
            set { city = value; }
        }

        public Suburb Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public override string ToString()
        {
            return "Street Address: " + this.StreetAddress + "\n" +
                "Suburb        : ";

        }
    }
}
