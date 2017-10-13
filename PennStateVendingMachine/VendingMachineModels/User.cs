using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class User
    {
        private int iD;
        private string firstName;
        private string lastName;
        private string username;
        private string password;
        private string emailAddress;
        private string contactNumber;
        private Profile profile;

        public User()
        {

        }

        public User(int IDParam, string FirstNameParam, string LastNameParam, string UsernameParam, string PasswordParam, string EmailAddressParam, string ContactNumberParam, Profile ProfileParam)
        {
            this.ID = IDParam;
            this.FirstName = FirstNameParam;
            this.LastName = LastNameParam;
            this.Username = UsernameParam;
            this.Password = PasswordParam;
            this.EmailAddress = EmailAddressParam;
            this.ContactNumber = ContactNumberParam;
            this.Profile = ProfileParam;
        }

        public Profile Profile
        {
            get { return profile; }
            set { profile = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
