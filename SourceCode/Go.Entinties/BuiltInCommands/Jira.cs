using Go.Common.Entities;
using System.Diagnostics;

namespace Go.Common.BuiltInCommands
{
    public class Jira : BuiltInCommand
    {
        public Jira()
        {}
        public override bool Execute(string parameter)
        {
            string jiraURL = Configuration;
            var fullPath = jiraURL + parameter;
            Process.Start(fullPath);
            return true;
        }
    }
}
