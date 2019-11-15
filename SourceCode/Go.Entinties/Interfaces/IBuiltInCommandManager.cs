using Go.Common.Entities;
using System.Collections.Generic;
using System.Data;

namespace Go.Common.Interfaces
{
    public interface IBuiltInCommandManager
    {
        bool isThisExists(string cmdName);
        List<string> GetNames();
        BuiltInCommand Get(string cmdName);
        bool Update(string oldCommand, string newCommand, string newParameter);

        DataTable GetBuiltInCommandDT();
    }
}
