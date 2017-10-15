using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess._110_DatabaseSystem._111_Models;
using VendingMachineModels;

namespace DTOConversion
{
    public static class DTOConversion
    {
        #region ToModel
        
        #region DTO to Model

        public static Role ToModel(this RoleDTO ObjectToConvert)
        {
            return new Role()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static ProductType ToModel(this ProductTypeDTO ObjectToConvert)
        {
            return new ProductType()
            {
                ID = ObjectToConvert.ID,
                Descripton = ObjectToConvert.Descripton
            };
        }

        public static Country ToModel(this CountryDTO ObjectToConvert)
        {
            return new Country()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static City ToModel(this CityDTO ObjectToConvert)
        {
            return new City()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static Province ToModel(this ProvinceDTO ObjectToConvert)
        {
            return new Province()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static Suburb ToModel(this SuburbDTO ObjectToConvert)
        {
            return new Suburb()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name,
                PostalCode = ObjectToConvert.PostalCode
            };
        }

        public static Company ToModel(this CompanyDTO ObjectToConvert)
        {
            return new Company()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static CompartmentType ToModel(this CompartmentTypeDTO ObjectToConvert)
        {
            return new CompartmentType()
            {
                ID = ObjectToConvert.ID,
                Description = ObjectToConvert.Description
            };
        }

        public static Profile ToModel(this ProfileDTO ObjectToConvert)
        {
            return new Profile()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name,
                Roles = ObjectToConvert.Roles.Select(x => x.ToModel()).ToList()
            };
        }

        public static Address ToModel(this AddressDTO ObjectToConvert)
        {
            return new Address()
            {
                ID = ObjectToConvert.ID,
                StreetAddress = ObjectToConvert.StreetAddress,
                Suburb = ObjectToConvert.Suburb.ToModel(),
                City = ObjectToConvert.City.ToModel(),
                Province = ObjectToConvert.Province.ToModel(),
                Country = ObjectToConvert.Country.ToModel()
            };
        }

        public static User ToModel(this UserDTO ObjectToConvert)
        {
            return new User()
            {
                ID = ObjectToConvert.ID,
                FirstName = ObjectToConvert.FirstName,
                LastName = ObjectToConvert.LastName,
                Username = ObjectToConvert.Username,
                Password = ObjectToConvert.Password,
                ContactNumber = ObjectToConvert.ContactNumber,
                EmailAddress = ObjectToConvert.EmailAddress,
                Profile = ObjectToConvert.Profile.ToModel()
            };
        }

        public static Branch ToModel(this BranchDTO ObjectToConvert)
        {
            return new Branch()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name,
                Company = ObjectToConvert.Company.ToModel(),
                Address = ObjectToConvert.Address.ToModel(),
                Users = ObjectToConvert.Users.Select(x => x.ToModel()).ToList()
            };
        }

        public static Compartment ToModel(this CompartmentDTO ObjectToConvert)
        {
            return new Compartment()
            {
                ID = ObjectToConvert.ID,
                Description = ObjectToConvert.Description,
                Capacity = ObjectToConvert.Capacity,
                CompartmentType = ObjectToConvert.CompartmentType.ToModel()
            };
        }

        public static VendingMachine ToModel(this VendingMachineDTO ObjectToConvert)
        {
            return new VendingMachine()
            {
                ID = ObjectToConvert.ID,
                SerialNumber = ObjectToConvert.SerialNumber,
                Address = ObjectToConvert.Address.ToModel(),
                Branch = ObjectToConvert.Branch.ToModel()
            };
        }

        public static UserLog ToModel(this UserLogDTO ObjectToConvert)
        {
            return new UserLog()
            {
                ID = ObjectToConvert.ID,
                IPAddress = ObjectToConvert.IPAddress,
                DateTimeLogged = ObjectToConvert.DateTimeLogged,
                User = ObjectToConvert.User.ToModel()
            };
        }

        public static VendingMachineLog ToModel(this VendingMachineLogDTO ObjectToConvert)
        {
            return new VendingMachineLog()
            {
                ID = ObjectToConvert.ID,
                //Successful = ObjectToConvert.Successful,
                DateTimeLogged = ObjectToConvert.DateTimeLogged,
                VendingMachine = ObjectToConvert.VendingMachine.ToModel()
            };
        }

        public static Product ToModel(this ProductDTO ObjectToConvert)
        {
            return new Product()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name,
                ProductType = ObjectToConvert.ProductType.ToModel()
            };
        }

        public static VendingMachineProduct ToModel(this VendingMachineProductDTO ObjectToConvert)
        {
            return new VendingMachineProduct()
            {
                Cost = ObjectToConvert.Cost,
                StockOnHand = ObjectToConvert.StockOnHand,
                VendingMachine = ObjectToConvert.VendingMachine.ToModel(),
                Compartment = ObjectToConvert.Compartment.ToModel(),
                Product = ObjectToConvert.Product.ToModel()
            };
        }

        public static VendingMachinePurchase ToModel(this VendingMachinePurchaseDTO ObjectToConvert)
        {
            return new VendingMachinePurchase()
            {
                ID = ObjectToConvert.ID,
                Cost = ObjectToConvert.Cost,
                Quantity = ObjectToConvert.Quantity,
                DateTimePurchased = ObjectToConvert.DateTimePurchased,
                Product = ObjectToConvert.Product.ToModel(),
                VendingMachine = ObjectToConvert.VendingMachine.ToModel()
            };
        }

        #endregion

        #endregion

        #region Model to DTO

        public static RoleDTO ToDTO(this Role ObjectToConvert)
        {
            return new RoleDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static ProductTypeDTO ToDTO(this ProductType ObjectToConvert)
        {
            return new ProductTypeDTO()
            {
                ID = ObjectToConvert.ID,
                Descripton = ObjectToConvert.Descripton
            };
        }

        public static CountryDTO ToDTO(this Country ObjectToConvert)
        {
            return new CountryDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static CityDTO ToDTO(this City ObjectToConvert)
        {
            return new CityDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static ProvinceDTO ToDTO(this Province ObjectToConvert)
        {
            return new ProvinceDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static SuburbDTO ToDTO(this Suburb ObjectToConvert)
        {
            return new SuburbDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name,
                PostalCode = ObjectToConvert.PostalCode
            };
        }

        public static CompanyDTO ToDTO(this Company ObjectToConvert)
        {
            return new CompanyDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name
            };
        }

        public static CompartmentTypeDTO ToDTO(this CompartmentType ObjectToConvert)
        {
            return new CompartmentTypeDTO()
            {
                ID = ObjectToConvert.ID,
                Description = ObjectToConvert.Description
            };
        }

        public static ProfileDTO ToDTO(this Profile ObjectToConvert)
        {
            return new ProfileDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name,
                Roles = ObjectToConvert.Roles.Select(x => x.ToDTO()).ToList()
            };
        }

        public static AddressDTO ToDTO(this Address ObjectToConvert)
        {
            return new AddressDTO()
            {
                ID = ObjectToConvert.ID,
                StreetAddress = ObjectToConvert.StreetAddress,
                Suburb = ObjectToConvert.Suburb.ToDTO(),
                City = ObjectToConvert.City.ToDTO(),
                Province = ObjectToConvert.Province.ToDTO(),
                Country = ObjectToConvert.Country.ToDTO()
            };
        }

        public static UserDTO ToDTO(this User ObjectToConvert)
        {
            return new UserDTO()
            {
                ID = ObjectToConvert.ID,
                FirstName = ObjectToConvert.FirstName,
                LastName = ObjectToConvert.LastName,
                Username = ObjectToConvert.Username,
                Password = ObjectToConvert.Password,
                ContactNumber = ObjectToConvert.ContactNumber,
                EmailAddress = ObjectToConvert.EmailAddress,
                Profile = ObjectToConvert.Profile.ToDTO()
            };
        }

        public static BranchDTO ToDTO(this Branch ObjectToConvert)
        {
            return new BranchDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name,
                Company = ObjectToConvert.Company.ToDTO(),
                Address = ObjectToConvert.Address.ToDTO(),
                Users = ObjectToConvert.Users.Select(x => x.ToDTO()).ToList()
            };
        }

        public static CompartmentDTO ToDTO(this Compartment ObjectToConvert)
        {
            return new CompartmentDTO()
            {
                ID = ObjectToConvert.ID,
                Description = ObjectToConvert.Description,
                Capacity = ObjectToConvert.Capacity,
                CompartmentType = ObjectToConvert.CompartmentType.ToDTO()
            };
        }

        public static VendingMachineDTO ToDTO(this VendingMachine ObjectToConvert)
        {
            return new VendingMachineDTO()
            {
                ID = ObjectToConvert.ID,
                SerialNumber = ObjectToConvert.SerialNumber,
                Address = ObjectToConvert.Address.ToDTO(),
                Branch = ObjectToConvert.Branch.ToDTO()
            };
        }

        public static UserLogDTO ToDTO(this UserLog ObjectToConvert)
        {
            return new UserLogDTO()
            {
                ID = ObjectToConvert.ID,
                IPAddress = ObjectToConvert.IPAddress,
                DateTimeLogged = ObjectToConvert.DateTimeLogged,
                User = ObjectToConvert.User.ToDTO()
            };
        }

        public static VendingMachineLogDTO ToDTO(this VendingMachineLog ObjectToConvert)
        {
            return new VendingMachineLogDTO()
            {
                ID = ObjectToConvert.ID,
                DateTimeLogged = ObjectToConvert.DateTimeLogged,
                VendingMachine = ObjectToConvert.VendingMachine.ToDTO()
            };
        }

        public static ProductDTO ToDTO(this Product ObjectToConvert)
        {
            return new ProductDTO()
            {
                ID = ObjectToConvert.ID,
                Name = ObjectToConvert.Name,
                ProductType = ObjectToConvert.ProductType.ToDTO()
            };
        }

        public static VendingMachineProductDTO ToDTO(this VendingMachineProduct ObjectToConvert)
        {
            return new VendingMachineProductDTO()
            {
                Cost = ObjectToConvert.Cost,
                StockOnHand = ObjectToConvert.StockOnHand,
                VendingMachine = ObjectToConvert.VendingMachine.ToDTO(),
                Compartment = ObjectToConvert.Compartment.ToDTO(),
                Product = ObjectToConvert.Product.ToDTO()
            };
        }

        public static VendingMachinePurchaseDTO ToDTO(this VendingMachinePurchase ObjectToConvert)
        {
            return new VendingMachinePurchaseDTO()
            {
                ID = ObjectToConvert.ID,
                Cost = ObjectToConvert.Cost,
                Quantity = ObjectToConvert.Quantity,
                DateTimePurchased = ObjectToConvert.DateTimePurchased,
                Product = ObjectToConvert.Product.ToDTO(),
                VendingMachine = ObjectToConvert.VendingMachine.ToDTO()
            };
        }

        #endregion

        
    }
}
