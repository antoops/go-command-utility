using Go.Common.Entities;
using System.Diagnostics;

namespace Go.Common.BuiltInCommands
{
    public class ServiceNow : BuiltInCommand
    {
        public ServiceNow()
        {}
        public override bool Execute(string parameter)
        {
            string SNURL = Configuration;
            string OpenString = string.Empty;
            string fullPath = string.Empty;
            bool urlComplete = false;
            // Deciding whether the entered number is Incident/ChangeRequest/Problem
            if (parameter.StartsWith("inc"))
            {
                // 1. Incident : Setting url continuation for an incident 
                OpenString = "incident.do?sys_id=";
            }
            else if (parameter.StartsWith("chg"))
            {
                // 2. Change : Setting url continuation for an Change request  
                OpenString = "nav_to.do?uri=change_request.do?sysparm_query=number=";
            }
            else if (parameter.StartsWith("ctask"))
            {
                // 3. Change task : Setting url continuation for an change task
                parameter = "change_task.do?sys_id=";
            }
            else if (parameter.StartsWith("prb"))
            {
                // 4. Problem  : Setting URL continuation for an problem   
                OpenString = "problem.do?sys_id=";
            }
            else if (parameter.StartsWith("ptask"))
            {
                // 5. problem task : Setting url continuation for an problem task  
                OpenString = "u_problem_task.do?sys_id=";
            }
            else if (parameter.StartsWith("task"))
            {
                // 6. Catalogue task : Setting url continuation for an catalogue request  
                OpenString = "sc_task.do?sys_id=";
            }
            else if (parameter.StartsWith("req"))
            {
                // 7. Request task : Setting url continuation for an request task
                OpenString = "sc_request.do?sys_id=";
            }
            else if (parameter.StartsWith("kb"))
            {
                // 8. Knowledge article : Setting url continuation for an KB
                fullPath = SNURL + "nav_to.do?uri=%2Fkb_view.do%3Fsysparm_article%3D" +
                    parameter + "%26sysparm_stack%3D%26sysparm_view%3D";
                urlComplete = true;
            }
            else
            {
                // Default string for search 
                OpenString = "textsearch.do?sysparm_view=text_search&sysparm_search=";
            }
            if(!urlComplete)
                fullPath = SNURL + OpenString + parameter;
            Process.Start(fullPath);
            return true;
        }
    }
}
