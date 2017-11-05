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
    public class RoleController
    {
        public List<RoleDTO> GetAllRoles()
        {
            return new RoleService().SelectAll().Select(x => x.ToDTO()).ToList();
        }

        public RoleDTO GetRole(int RoleID)
        {
            List<RoleDTO> allRoles = GetAllRoles();

            for (int i = 0; i < allRoles.Count; i++)
            {
                if (allRoles[i].ID == RoleID)
                {
                    return allRoles[i];
                }
            }
            throw new ElementNotFoundException("Unable to find Role with ID: " + RoleID);
        }
    }
}
