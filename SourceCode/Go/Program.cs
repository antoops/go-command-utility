using Go.Common;
using Go.DataAccess;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace Go
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var profileFilePath = ConfigurationManager.AppSettings.Get(Constants.ProfileFilePath);
            var commandFilePath = ConfigurationManager.AppSettings.Get(Constants.CustomCommandFilePath);
            var builtInCommandFilePath = ConfigurationManager.AppSettings.Get(Constants.BuiltInCommandFilePath);

            CommandManager cmdMgr = new CommandManager(profileFilePath, commandFilePath, builtInCommandFilePath,
                Application.StartupPath);
            string inputParameter =string.Empty;
            //checking the argument
            if (args.Length > 0)
            {
                //have argument, so proceed
                //Fetching the command line argument
                string inputCommandName = args[0];
                if (args.Length > 1)
                {
                    inputParameter = args[1];
                    if (args.Length > 1)
                    {
                        for (int i = 2; i < args.Length; i++)
                            inputParameter = inputParameter + " " + args[i];
                    }
                }
                inputCommandName = inputCommandName.ToLower();

                //Edit Options
                if (inputCommandName == Constants.ReservedCmdEditOptions)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new frmSettings());
                    Application.Run(new frmCustomCommands());
                }
                else//Command mode
                {
                    //if builtin command, load builtin command class by passing the properties.settings for config
                    if (cmdMgr.isThisBuiltInCommandExists(inputCommandName))
                    {
                        var buittInCommand = cmdMgr.GetBuiltInCommand(inputCommandName);
                        buittInCommand.Execute(inputParameter.ToLower());

                    }
                    else if(cmdMgr.isThisCustomCommandExists(inputCommandName))//custom command, load it and execute
                    {
                        var customCommand = cmdMgr.GetCustomCommand(inputCommandName);
                        customCommand.Execute(inputParameter.ToLower());
                    }
                    else
                    {
                        try
                        {
                            Process.Start(inputCommandName, inputParameter);
                        }
                        catch (Exception)
                        {

                        } 
                    }
                }

                //switch (inputCommandName)
                //{
                //    case Constants.ReservedCmdEditOptions:

                //        Application.EnableVisualStyles();
                //        Application.SetCompatibleTextRenderingDefault(false);
                //        Application.Run(new frmSettings());
                //        break;

                //    case Constants.ReservedCmdGetMyIP:
                //        GoProcess.getMyIP();
                //        break;

                //    case Constants.ReservedCmdGetMyMac:
                //        GoProcess.GetMacAddress();
                //        break;
                //    default:
                //        // not for editing, so directly opening the window
                //        // first need to check for custom commands
                //        if (myProcess.IsCustomCommand(inputCommandName))
                //        {
                //            myProcess.ProcessCustomCommand(inputCommandName,inputParameter);
                //        }
                //        else
                //        {
                //          //else go for browser
                //          myProcess.OpenURL(inputCommandName);
                //        }

                //        break;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmInput());
            } 
        }
    }
}
