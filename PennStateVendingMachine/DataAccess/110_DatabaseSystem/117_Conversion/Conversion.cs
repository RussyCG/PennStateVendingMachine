using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess._110_DatabaseSystem._111_Models;
using System.Data;

namespace DataAccess._110_DatabaseSystem._117_Conversion
{
    public static class Conversion
    {
        #region ToModels

        public static List<Role> ToRoles(this DataTable TableToConvert)
        {
            List<Role> temp = new List<Role>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToRole());
            }
            return temp;
        }

        public static List<ProductType> ToProductTypes(this DataTable TableToConvert)
        {
            List<ProductType> temp = new List<ProductType>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToProductType());
            }
            return temp;
        }

        public static List<Country> ToCountries(this DataTable TableToConvert)
        {
            List<Country> temp = new List<Country>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToCountry());
            }
            return temp;
        }

        public static List<City> ToCities(this DataTable TableToConvert)
        {
            List<City> temp = new List<City>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToCity());
            }
            return temp;
        }

        public static List<Province> ToProvinces(this DataTable TableToConvert)
        {
            List<Province> temp = new List<Province>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToProvince());
            }
            return temp;
        }

        public static List<Suburb> ToSuburbs(this DataTable TableToConvert)
        {
            List<Suburb> temp = new List<Suburb>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToSuburb());
            }
            return temp;
        }

        public static List<Company> ToCompanies(this DataTable TableToConvert)
        {
            List<Company> temp = new List<Company>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToCompany());
            }
            return temp;
        }

        public static List<CompartmentType> ToCompartmentTypes(this DataTable TableToConvert)
        {
            List<CompartmentType> temp = new List<CompartmentType>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToCompartmentType());
            }
            return temp;
        }
        // Add normal ToProfiles
        public static List<Profile> ToProfilesWithoutRoles(this DataTable TableToConvert)
        {
            List<Profile> temp = new List<Profile>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToProfileNoRoles());
            }
            return temp;
        }

        public static List<Address> ToAddresses(this DataTable TableToConvert)
        {
            List<Address> temp = new List<Address>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToAddress());
            }
            return temp;
        }

        public static List<User> ToUsers(this DataTable TableToConvert)
        {
            List<User> temp = new List<User>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToUser());
            }
            return temp;
        }

        public static List<Branch> ToBranches(this DataTable TableToConvert)
        {
            List<Branch> temp = new List<Branch>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToBranchWithNoUsers());
            }
            return temp;
        }

        public static List<Compartment> ToCompartments(this DataTable TableToConvert)
        {
            List<Compartment> temp = new List<Compartment>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToCompartment());
            }
            return temp;
        }

        public static List<VendingMachine> ToVendingMachines(this DataTable TableToConvert)
        {
            List<VendingMachine> temp = new List<VendingMachine>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToVendingMachine());
            }
            return temp;
        }

        public static List<UserLog> ToUserLogs(this DataTable TableToConvert)
        {
            List<UserLog> temp = new List<UserLog>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToUserLog());
            }
            return temp;
        }

        public static List<VendingMachineLog> ToVendingMachineLogs(this DataTable TableToConvert)
        {
            List<VendingMachineLog> temp = new List<VendingMachineLog>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToVendingMachineLog());
            }
            return temp;
        }

        public static List<Product> ToProducts(this DataTable TableToConvert)
        {
            List<Product> temp = new List<Product>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToProduct());
            }
            return temp;
        }

        public static List<VendingMachineProduct> ToVendingMachineProducts(this DataTable TableToConvert)
        {
            List<VendingMachineProduct> temp = new List<VendingMachineProduct>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToVendingMachineProduct());
            }
            return temp;
        }

        public static List<VendingMachinePurchase> ToVendingMachinePurchases(this DataTable TableToConvert)
        {
            List<VendingMachinePurchase> temp = new List<VendingMachinePurchase>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToVendingMachinePurchase());
            }
            return temp;
        }

        public static List<Session> ToSessions(this DataTable TableToConvert)
        {
            List<Session> temp = new List<Session>();
            foreach (DataRow row in TableToConvert.Rows)
            {
                temp.Add(row.ToSession());
            }
            return temp;
        }

        #endregion

        #region ToModel

        public static Role ToRole(this DataRow RowToConvert)
        {
            return new Role()
            {
                ID = int.Parse(RowToConvert[Role.TableName + "_ID"].ToString()),
                Name = RowToConvert[Role.TableName + "_Name"].ToString()
            };
        }

        public static ProductType ToProductType(this DataRow RowToConvert)
        {
            return new ProductType()
            {
                ID = int.Parse(RowToConvert[ProductType.TableName + "_ID"].ToString()),
                Descripton = RowToConvert[Role.TableName + "_Description"].ToString()
            };
        }

        public static Country ToCountry(this DataRow RowToConvert)
        {
            return new Country()
            {
                ID = int.Parse(RowToConvert[Country.TableName + "_ID"].ToString()),
                Name = RowToConvert[Country.TableName + "_Name"].ToString()
            };
        }

        public static City ToCity(this DataRow RowToConvert)
        {
            return new City()
            {
                ID = int.Parse(RowToConvert[City.TableName + "_ID"].ToString()),
                Name = RowToConvert[Country.TableName + "_Name"].ToString()
            };
        }

        public static Province ToProvince(this DataRow RowToConvert)
        {
            return new Province()
            {
                ID = int.Parse(RowToConvert[Province.TableName + "_ID"].ToString()),
                Name = RowToConvert[Province.TableName + "_Name"].ToString()
            };
        }

        public static Suburb ToSuburb(this DataRow RowToConvert)
        {
            return new Suburb()
            {
                ID = int.Parse(RowToConvert[Suburb.TableName + "_ID"].ToString()),
                Name = RowToConvert[Suburb.TableName + "_Name"].ToString(),
                PostalCode = RowToConvert[Suburb.TableName + "_PostalCode"].ToString()
            };
        }

        public static Company ToCompany(this DataRow RowToConvert)
        {
            return new Company()
            {
                ID = int.Parse(RowToConvert[Company.TableName + "_ID"].ToString()),
                Name = RowToConvert[Company.TableName + "_Name"].ToString()
            };
        }

        public static CompartmentType ToCompartmentType(this DataRow RowToConvert)
        {
            return new CompartmentType()
            {
                ID = int.Parse(RowToConvert[CompartmentType.TableName + "_ID"].ToString()),
                Description = RowToConvert[CompartmentType.TableName + "_Description"].ToString()
            };
        }

        public static Profile ToProfile(this DataTable TableToConvert)
        {
            if (TableToConvert == null || TableToConvert.Rows.Count <=0)
                return null;

            Profile profile = TableToConvert.Rows[0].ToProfileNoRoles();
            foreach (DataRow row in TableToConvert.Rows)
            {
                profile.Roles.Add(row.ToRole());
            }

            return profile;
        }
        
        public static Profile ToProfileNoRoles(this DataRow RowToConvert)
        {
            return new Profile()
            {
                ID = int.Parse(RowToConvert[Profile.TableName + "_ID"].ToString()),
                Name = RowToConvert[Profile.TableName + "_Name"].ToString(),
                Roles = null
            };
        }

        public static Address ToAddress(this DataRow RowToConvert)
        {
            return new Address()
            {
                ID = int.Parse(RowToConvert[Address.TableName + "_ID"].ToString()),
                StreetAddress = RowToConvert[Address.TableName + "_StreetAddress"].ToString(),
                Suburb = RowToConvert.ToSuburb(),
                City = RowToConvert.ToCity(),
                Province = RowToConvert.ToProvince(),
                Country = RowToConvert.ToCountry()
            };
        }

        public static User ToUser(this DataRow RowToConvert)
        {
            return new User()
            {
                ID = int.Parse(RowToConvert[User.TableName + "_ID"].ToString()),
                FirstName = RowToConvert[User.TableName + "_FirstName"].ToString(),
                LastName = RowToConvert[User.TableName + "_LastName"].ToString(),
                Username = RowToConvert[User.TableName + "_Username"].ToString(),
                Password = RowToConvert[Address.TableName + "_Password"].ToString(),
                ContactNumber = RowToConvert[Address.TableName + "_ContactNumber"].ToString(),
                EmailAddress = RowToConvert[Address.TableName + "_EmailAddress"].ToString(),
                Profile = RowToConvert.ToProfileNoRoles()
            };
        }
        // Add normal to Branch
        public static Branch ToBranchWithNoUsers(this DataRow RowToConvert)
        {
            return new Branch()
            {
                ID = int.Parse(RowToConvert[Branch.TableName + "_ID"].ToString()),
                Name = RowToConvert[Branch.TableName + "_Name"].ToString(),
                Company = RowToConvert.ToCompany(),
                Address = RowToConvert.ToAddress(),
                Users = null
                //Users = RowToConvert.Users.Select(x => x.ToModel()).ToList()
            };
        }

        public static Compartment ToCompartment(this DataRow RowToConvert)
        {
            return new Compartment()
            {
                ID = int.Parse(RowToConvert[Compartment.TableName + "_ID"].ToString()),
                Description = RowToConvert[Compartment.TableName + "_Description"].ToString(),
                Capacity = int.Parse(RowToConvert[Compartment.TableName + "_Capacity"].ToString()),
                CompartmentType = RowToConvert.ToCompartmentType()
            };
        }

        public static VendingMachine ToVendingMachine(this DataRow RowToConvert)
        {
            return new VendingMachine()
            {
                ID = int.Parse(RowToConvert[VendingMachine.TableName + "_ID"].ToString()),
                SerialNumber = RowToConvert[VendingMachine.TableName + "_SerialNumber"].ToString(),
                Address = RowToConvert.ToAddress(),
                Branch = RowToConvert.ToBranchWithNoUsers()
            };
        }

        public static UserLog ToUserLog(this DataRow RowToConvert)
        {
            return new UserLog()
            {
                ID = int.Parse(RowToConvert[UserLog.TableName + "_ID"].ToString()),
                IPAddress = RowToConvert[UserLog.TableName + "_IPAddress"].ToString(),
                DateTimeLogged = (DateTime)RowToConvert[UserLog.TableName + "_DateTimeLogged"],
                User = RowToConvert.ToUser()
            };
        }

        public static VendingMachineLog ToVendingMachineLog(this DataRow RowToConvert)
        {
            return new VendingMachineLog()
            {
                ID = int.Parse(RowToConvert[VendingMachineLog.TableName + "_ID"].ToString()),
                //Successful = (bool x) => { RowToConvert[VendingMachineLog.TableName + "_Successful"].ToString() == "1" ? return true; },
                DateTimeLogged = (DateTime)RowToConvert[VendingMachineLog.TableName + "_DateTimeLogged"],
                VendingMachine = RowToConvert.ToVendingMachine()
            };
        }

        public static Product ToProduct(this DataRow RowToConvert)
        {
            return new Product()
            {
                ID = int.Parse(RowToConvert[Product.TableName + "_ID"].ToString()),
                Name = RowToConvert[Product.TableName + "_Name"].ToString(),
                ProductType = RowToConvert.ToProductType()
            };
        }

        public static VendingMachineProduct ToVendingMachineProduct(this DataRow RowToConvert)
        {
            return new VendingMachineProduct()
            {
                Cost = double.Parse(RowToConvert[VendingMachineProduct.TableName + "_Cost"].ToString()),
                StockOnHand = int.Parse(RowToConvert[VendingMachineProduct.TableName + "_StockOnHand"].ToString()),
                VendingMachine = RowToConvert.ToVendingMachine(),
                Compartment = RowToConvert.ToCompartment(),
                Product = RowToConvert.ToProduct()
            };
        }

        public static VendingMachinePurchase ToVendingMachinePurchase(this DataRow RowToConvert)
        {
            return new VendingMachinePurchase()
            {
                ID = int.Parse(RowToConvert[VendingMachinePurchase.TableName + "_ID"].ToString()),
                Cost = double.Parse(RowToConvert[VendingMachinePurchase.TableName + "_Cost"].ToString()),
                Quantity = int.Parse(RowToConvert[VendingMachinePurchase.TableName + "_Quantity"].ToString()),
                DateTimePurchased = (DateTime)RowToConvert[VendingMachinePurchase.TableName + "_DateTimePurchase"],
                Product = RowToConvert.ToProduct(),
                VendingMachine = RowToConvert.ToVendingMachine()
            };
        }

        public static Session ToSession(this DataRow RowToConvert)
        {
            return new Session()
            {
                ID = RowToConvert[Session.TableName + "_ID"].ToString(),
                User = RowToConvert.ToUser(),
                LogDateTime = (DateTime)RowToConvert[Session.TableName + "_LogDateTime"]
            };
        }

        #endregion
    }
}
