using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class UserLogDTO
    {
        private int iD;
        private UserDTO user;
        private DateTime dateTimeLogged;
        private string ipAddress;

        public UserLogDTO()
        {

        }

        public UserLogDTO(int IDParam, UserDTO UserParam, DateTime DateTimeLoggedParam, string IPAddressParam)
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

        public UserDTO User
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
