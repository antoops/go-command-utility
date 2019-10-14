
using System.Data;

namespace Go.Common
{
    public class Constants
    {
        //General
        public const string TabSpace = "  ";

        //Browser application names
        public const string DefaultBrowser = "Default";
        public const string IEBrowser = "IExplore";
        public const string ChromeBrowser = "chrome";
        public const string FirefoxBrowser = "fireFox";

        //Key names from application settings
        public const string ServiceNowBrowserOption = "ServiceNowBrowserOption";
        public const string ServiceNowFlag = "ServiceNowFlag";
        public const string ServiceNowURL = "ServiceNowURL";


        // Browser options
        public const string BrowserDefault = "Default";
        public const string BrowserIE = "InternetExplorer";
        public const string BrowserChrome = "Chrome";
        public const string BrowserFirefox = "FireFox";

        //Default values for each settings
        public const string DefaultServiceNowBrowserOption = "Default";
        public const string DefaultServiceNowURL = "http://mycompany.service-now.com/";

        public const string DefaultServiceNowFlag = "True";
        public const string CustomCommandName = "Command_Name";
        public const string CustomCommandAction = "Command_Action";
        public const string CustomCommandParameter = "Command_Parameter";

        public const string CustomCommandTableName = "Command";
        public const string CustomCommandDataSetName = "CustomCommands";
        public const string SYSTEMROOT = "SYSTEMROOT";
        public const string SytemRootString = "%systemroot%";
        public const string HTTPString = "http";
        

        public const string AppliCationName = "Go Utility";
        public const string CustomCommandsFileName = "C:\\GoUtility\\CustomCommands.xml";


        //Reserved command operations
        public const string ReservedCmdEditOptions = "editoptions";
        public const string ReservedCmdGetMyIP = "getmyip";
        public const string ReservedCmdGetMyMac = "getmymac";
        public const string ReservedSNINC = "inc";
        public const string ReservedSNCHG = "chg";
        public const string ReservedSNCTASK = "ctask"; 
        public const string ReservedSNPRB = "prb" ;
        public const string ReservedSNPTASK = "ptask"; 
        public const string ReservedSNTASK = "task";
        public const string ReservedSNREQ = "req";
         public static readonly string ProfileFilePath = "ProfilesFilePath";
        public static readonly string BuiltInCommandFilePath = "BuiltinCommandsFilePath";
        public static readonly string Name = "Name";
        public static readonly string Profile = "Profile";
        public static readonly string ActionScript = "ActionScript";
        public static readonly string Parameter = "Parameter";
        public static readonly string CommandFilePath = "CommandFilePath";
        public static string CustomCommandFilePath = "CustomCommandsFilePath";
    }
}
