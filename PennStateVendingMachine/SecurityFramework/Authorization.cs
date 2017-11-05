using SecurityFramework.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineControllers;
using VendingMachineModels.DTOs;

namespace SecurityFramework
{
    public class Authorization
    {
        public bool isAuthorizedAction(string SessionID, RoleDTO methodRole)
        {
            UserDTO userRequestingAction = new SessionController().GetUser(SessionID);

            return userRequestingAction == null ? throw new InvalidSessionException() : isAuthorizedToPerformRole(userRequestingAction, methodRole);
        }

        private bool isAuthorizedToPerformRole(UserDTO user, RoleDTO role)
        {
            return user.Profile.Roles.Contains(role);
        }
    }
}
