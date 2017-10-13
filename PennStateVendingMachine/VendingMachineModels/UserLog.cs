using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class UserLog
    {
        private int iD;
        private User user;
        private DateTime dateTimeLogged;
        private string ipAddress;

        public UserLog()
        {

        }

        public UserLog(int IDParam, User UserParam, DateTime DateTimeLoggedParam, string IPAddressParam)
        {
            this.ID = IDParam;
            this.User = UserParam;
            this.DateTimeLogged = DateTimeLoggedParam;
            this.IPAddress = IPAddressParam;
        }

        public string IPAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

        public DateTime DateTimeLogged
        {
            get { return dateTimeLogged; }
            set { dateTimeLogged = value; }
        }

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
