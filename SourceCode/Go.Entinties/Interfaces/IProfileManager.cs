using Go.Common.Entities;
using System.Collections.Generic;
using System.Data;

namespace Go.Common.Interfaces
{
    public interface IProfileManager
    {
        bool isThisExists(string profileName);
        List<string> GetAllProfileNames();
        List<Profile> GetAll();
        Profile Get(string profileName);
        string GetCommandPath(string profileName);
        bool Add(Profile newProfile);
        bool Update(Profile oldProfile, Profile newProfile);
        bool Delete(string profileName);
        DataTable GetProfileDT();
    }
}
