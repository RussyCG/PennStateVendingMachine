using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels.DTOs
{
    public class AddressDTO
    {
        private int iD;
        private string streetAddress;
        private SuburbDTO suburb;
        private CityDTO city;
        private ProvinceDTO province;
        private CountryDTO country;

        public AddressDTO()
        {

        }

        public AddressDTO(int IDParam, string StreetAddressParam, SuburbDTO SuburbParam, CityDTO CityParam, ProvinceDTO ProvinceParam, CountryDTO CountryParam)
        {
            this.ID = IDParam;
            this.StreetAddress = StreetAddressParam;
            this.Suburb = SuburbParam;
            this.City = CityParam;
            this.Province = ProvinceParam;
            this.Country = CountryParam;
        }

        public CountryDTO Country
        {
            get { return country; }
            set { country = value; }
        }

        public ProvinceDTO Province
        {
            get { return province; }
            set { province = value; }
        }

        public CityDTO City
        {
            get { return city; }
            set { city = value; }
        }

        public SuburbDTO Suburb
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
