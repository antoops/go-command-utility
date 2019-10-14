using Go.Common.Entities;
using System.Collections.Generic;

namespace Go.Common.Interfaces
{
    public interface ICommandManager
    {
        bool isThisCustomCommandExists(string commandName);
        bool isThisBuiltInCommandExists(string commandName);
        List<string> GetAllCustomCommandNames();
        List<Profile> GetAllProfile();
        BuiltInCommand GetBuiltInCommand(string commandName);
        CustomCommand GetCustomCommand(string commandName);
        bool AddCustomCommand(CustomCommand customCommand);
        bool UpdateCustomCommand(CustomCommand oldCustomCommand, CustomCommand newCustomCommand);
        bool DeleteCustomCommand(CustomCommand customCommand);
    }
}
