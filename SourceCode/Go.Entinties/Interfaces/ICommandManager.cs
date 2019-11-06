using Go.Common.Entities;
using System.Collections.Generic;

namespace Go.Common.Interfaces
{
    public interface ICommandManager
    {
        bool isThisCustomCommandExists(string commandName);
        List<string> GetAllCustomCommandNames();
        List<Profile> GetAllProfile();
        BuiltInCommand GetBuiltInCommand(string commandName);
        CustomCommand GetCustomCommand(string commandName);
        bool AddCustomCommand(CustomCommand customCommand);
        bool UpdateCustomCommand(CustomCommand oldCustomCommand, CustomCommand newCustomCommand);
        bool DeleteCustomCommand(CustomCommand customCommand);
        //Profile
        Profile GetProfile(string profileName);
        bool UpdateProfile(Profile oldProfile, Profile newProfile);
        bool AddProfile(Profile newProfile);
        bool DeleteProfile(string profileName);
        bool isThisProfileExists(string newProfileName);

        //built in command
        IEnumerable<string> GetAllBuiltInCommandNames();
        bool isThisBuiltInCommandExists(string commandName);
        bool UpdateBuiltInCommand(string oldCommand, string newCommand, string newConfig);
    }
}
