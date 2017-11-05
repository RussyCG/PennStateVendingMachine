using DataAccess._110_DatabaseSystem._112_Services;
using DTOConversion;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModels.DTOs;

namespace VendingMachineControllers
{
    public class UserController
    {
        private List<UserDTO> GetAllUsers()
        {
            return new UserService().SelectAll().Select(x => x.ToDTO()).ToList();
        }

        public UserDTO GetUser(int UserID)
        {
            List<UserDTO> allUsers = GetAllUsers();

            for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].ID == UserID)
                {
                    return allUsers[i];
                }
            }
            throw new ElementNotFoundException("Unable to locate User with ID: " + UserID);
        }
    }
}
