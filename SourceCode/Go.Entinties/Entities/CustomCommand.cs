using Go.Common.Interfaces;
using System;
using System.Diagnostics;

namespace Go.Common.Entities
{
    public class CustomCommand : Command
    {
        
        public Profile Profile { get; set; }

        public CustomCommand()
        {
            Type = CommandType.Custom;
        }
       public override bool Execute(string nestedParameter)
        {
            string actionScript = ActionScript;
            string parameter = Parameter;
            if (nestedParameter.Trim().Length > 0)
                parameter = parameter + " " + nestedParameter;
            var SytemRootString = "%systemroot%";
            actionScript = actionScript.ToLower();
            //this is for replacing the system root directory if its used
            if (actionScript.ToLower().StartsWith(SytemRootString))
                actionScript = actionScript.Replace(SytemRootString, Environment.GetEnvironmentVariable("SYSTEMROOT"));

            Process.Start(actionScript, parameter);
            return true;
        }
    }
}
