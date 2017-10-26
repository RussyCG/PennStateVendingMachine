using DataAccess._110_DatabaseSystem._112_Services;
using DTOConversion;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModels;

namespace VendingMachineControllers
{
    public class ProfileController
    {
        public List<ProfileDTO> GetAllProfiles()
        {
            return new ProfileService().SelectAll().Select(x => x.ToDTO()).ToList();
        }

        public ProfileDTO GetProfile(int ProfileID)
        {
            List<ProfileDTO> allProfiles = GetAllProfiles();

            for (int i = 0; i < allProfiles.Count; i++)
            {
                if (allProfiles[i].ID == ProfileID)
                {
                    return allProfiles[i];
                }
            }
            throw new ElementNotFoundException("Unable to locate Profile with ID: " + ProfileID);
        }
    }
}
