using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class Address
    {
        public static string TableName = "Address";

        private int iD;
        private string streetAddress;
        private Suburb suburb;
        private City city;
        private Province province;
        private Country country;

        public Address()
        {

        }

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

    }
}
