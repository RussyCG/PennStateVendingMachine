using DataAccess._110_DatabaseSystem._112_Services;
using DTOConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModels.DTOs;

namespace VendingMachineControllers
{
    public class SessionController
    {
        public UserDTO GetUser(string SessionID)
        {
            return new SessionService().SelectOne(SessionID).User.ToDTO();
        }
    }
}
