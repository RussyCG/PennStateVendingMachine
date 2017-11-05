using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels.DTOs
{
    public class SessionDTO
    {
        private string sessionID;
        private UserDTO user;

        public SessionDTO(string SessionIDParam, UserDTO UserParam)
        {
            this.SessionID = SessionIDParam;
            this.User = UserParam;
        }

        public UserDTO User
        {
            get { return user; }
            set { user = value; }
        }

        public string SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

    }
}
