using Go.Common;
using Go.DataAccess;
using NLog;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Go
{
    static class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Logger.Info("GO Started");
            var profileFilePath = ConfigurationManager.AppSettings.Get(Constants.ProfileFilePath);
            var commandFilePath = ConfigurationManager.AppSettings.Get(Constants.CustomCommandFilePath);
            var builtInCommandFilePath = ConfigurationManager.AppSettings.Get(Constants.BuiltInCommandFilePath);
            try
            {
                Logger.Info("Startup Path : " + Application.StartupPath);
                var appPath = Application.StartupPath;

                var watch = System.Diagnostics.Stopwatch.StartNew();
                CommandManager cmdMgr = new CommandManager(profileFilePath, commandFilePath, builtInCommandFilePath,
                    appPath);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                Logger.Info("Command manager created within : " + elapsedMs.ToString() + " milliseconds");
                string inputParameter = string.Empty;
                //checking the argument
                if (args.Length > 0)
                {
                    //have argument, so proceed
                    //Fetching the command line argument
                    string inputCommandName = args[0];
                    Logger.Info("Got the command: " + inputCommandName);
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
                        Logger.Info("Opening the edit options");
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
                            Logger.Info("Its a built In Command");
                            var buittInCommand = cmdMgr.GetBuiltInCommand(inputCommandName);
                            var result = buittInCommand.Execute(inputParameter.ToLower());
                            Logger.Info("Built In Command executed = " + result);

                        }
                        else if (cmdMgr.isThisCustomCommandExists(inputCommandName))//custom command, load it and execute
                        {
                            Logger.Info("Its a custom Command");
                            var customCommand = cmdMgr.GetCustomCommand(inputCommandName);
                            var result = customCommand.Execute(inputParameter.ToLower());
                            Logger.Info("Custom Command executed = " + result);
                        }
                        else
                        {
                            Logger.Info("Custom Command not exists");

                            try
                            {
                                Logger.Info("Trying to open a process with that name");
                                Process.Start(inputCommandName, inputParameter);
                            }
                            catch (Exception e)
                            {
                                Logger.Info("Application or command don't exists, hence going for google search");
                                Process.Start("Chrome", "https://www.google.com/search?q=" + inputCommandName);
                            }
                        }
                    }

                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmInput());
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                Logger.Error(ex.StackTrace);
            }

        }
    }
}
