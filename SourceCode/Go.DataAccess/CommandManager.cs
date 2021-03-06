﻿using Go.Common;
using Go.Common.Entities;
using Go.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace Go.DataAccess
{
    public class CommandManager : ICommandManager
    {
        private readonly IXmlOperations _xmlOperations;
        private readonly IProfileManager  _profileManager;
        private readonly IBuiltInCommandManager  _builtInCommandManager;
        private readonly string _customCommandsFilePath;

        public DataTable CustomCommandsDT{ get; set; }
        public DataTable BuiltInCommandsDT{ get
            {
                return _builtInCommandManager.GetBuiltInCommandDT();
            } }
        public DataTable ProfilesDT{ 
            get
            {
                return _profileManager.GetProfileDT();
            } }
        public List<Command> Commands { get; set; }

        public CommandManager(string profileFilePath, string commandsFilePath, string builtInComandsFilePath,
            string applicationStartupPath)
            : this(new XmlOperations(applicationStartupPath), profileFilePath, commandsFilePath, builtInComandsFilePath, 
                  applicationStartupPath)
        {

        }
        public CommandManager(IXmlOperations xmlOperations, string profileFilePath,
            string customCommandsFilePath, string builtInComandsFilePath, string applicationStartupPath)
        {
            _xmlOperations = xmlOperations;
            _profileManager = new ProfileManager(profileFilePath, applicationStartupPath);
            _builtInCommandManager = new BuiltInCommandManager(builtInComandsFilePath, applicationStartupPath);
            //TODO parallel reading
            _customCommandsFilePath = Utilities.GetXmlPath(customCommandsFilePath, applicationStartupPath);
            CustomCommandsDT = _xmlOperations.GetXml(_customCommandsFilePath);
        }

        public IEnumerable<string> GetAllBuiltInCommandNames()
        {
           return  _builtInCommandManager.GetNames();
        }

        public Profile GetProfile(string profileName)
        {
            return _profileManager.Get(profileName);
        }

        public bool isThisCustomCommandExists(string commandName)
        {
            DataView customCommandsDV = new DataView(CustomCommandsDT)
            {
                Sort = "Name"
            };
          
            int commandIndex = customCommandsDV.Find(commandName);

            if (commandIndex == -1)
                return false;
            return true;
        }
        public bool isThisBuiltInCommandExists(string commandName)
        {
            return _builtInCommandManager.isThisExists(commandName);
        }

        public List<string> GetAllCustomCommandNames()
        {
            List<string> lstCustomCommands = new List<string>();
            foreach (DataRow dr in CustomCommandsDT.Rows)
            {
                lstCustomCommands.Add(dr["Name"].ToString());
            }
            return lstCustomCommands;
        }

        public CustomCommand GetCustomCommand(string commandName)
        {
            CustomCommand customCommand = null;
            //1. Find the profile of the given command
            DataView commandDV = new DataView(CustomCommandsDT)
            {
                Sort = "Name"
            };
            int commandIndex = commandDV.Find(commandName);

            if (commandIndex == -1)
                return null;
            else
            {
                customCommand = new CustomCommand
                {
                    Name = commandName
                };
                var profileName = commandDV[commandIndex]["Profile"].ToString();
                //int profileIndex = profileDV.Find(profileName);
                //if (profileIndex == -1) return null;
                var profile = new Profile
                {
                    Name = profileName,
                    CommandFilePath = GetProfileCommandPath(profileName)
                };
                customCommand.Profile = profile;

            }
          
            //2. Read the ProfileCommands file
            var profileCommandsDT = _xmlOperations.GetXml(customCommand.Profile.CommandFilePath);

            //3. Find the command details and return it
            using (DataView profileCommandsDV = new DataView(profileCommandsDT)
            {
                Sort = "Name"
            })
            {
                int profileCommandIndex = profileCommandsDV.Find(customCommand.Name);
                if (profileCommandIndex == -1) return null;
                customCommand.ActionScript = profileCommandsDV[profileCommandIndex]["ActionScript"].ToString();
                customCommand.Parameter = profileCommandsDV[profileCommandIndex]["Parameter"].ToString();
            }
            return customCommand;
        }

        public BuiltInCommand GetBuiltInCommand(string commandName)
        {
            ////1. Find the profile of the given command
            //DataView builtInCommandsDV = new DataView(BuiltInCommandsDT)
            //{
            //    Sort = "Name"
            //};

            //int builtInCommandIndex = builtInCommandsDV.Find(commandName);
            //if (builtInCommandIndex != -1)
            //{
            //    var ActionScript = builtInCommandsDV[builtInCommandIndex]["ActionScript"].ToString();
            //    var Parameter = builtInCommandsDV[builtInCommandIndex]["Parameter"].ToString();
            //    var type = Type.GetType("Go.Common.BuiltInCommands."+ ActionScript + ", Go.Common");
            //    var newBuiltInCommand = (BuiltInCommand)Activator.CreateInstance(type);
            //    newBuiltInCommand.Configuration = Parameter;
            //    return newBuiltInCommand;
            //}
            //return null;
            return _builtInCommandManager.Get(commandName);
        }

        public bool AddCustomCommand(CustomCommand customCommand)
        {
            var copyCustomCommandsDT = CustomCommandsDT.Copy();
            DataRow customCommandRow = copyCustomCommandsDT.NewRow();
            customCommandRow[Constants.Name] = customCommand.Name;
            customCommandRow[Constants.Profile] = customCommand.Profile.Name;
            copyCustomCommandsDT.Rows.Add(customCommandRow);

            //2. Read the ProfileCommands file
            customCommand.Profile.CommandFilePath = GetProfileCommandPath(customCommand.Profile.Name);
            DataTable profileCommandsDT;
            profileCommandsDT = _xmlOperations.GetXml(customCommand.Profile.CommandFilePath);
            if (profileCommandsDT == null)
                profileCommandsDT = GetDefaultProfileCommandDT();

            var copyProfileCommandsDT = profileCommandsDT.Copy();
            DataRow profileCommandRow = copyProfileCommandsDT.NewRow();
            profileCommandRow[Constants.Name] = customCommand.Name;
            profileCommandRow[Constants.ActionScript] = customCommand.ActionScript;
            profileCommandRow[Constants.Parameter] = customCommand.Parameter;
            copyProfileCommandsDT.Rows.Add(profileCommandRow);

            _xmlOperations.WriteXml(copyCustomCommandsDT, _customCommandsFilePath);
            CustomCommandsDT = copyCustomCommandsDT;
            _xmlOperations.WriteXml(copyProfileCommandsDT, customCommand.Profile.CommandFilePath);

            return true;
        }

        private string GetProfileCommandPath(string profileName)
        {
            return _profileManager.GetCommandPath(profileName);
        }

        public bool UpdateCustomCommand(CustomCommand oldCustomCommand, CustomCommand newCustomCommand)
        {
            //Find custom command row 
            //looping through the datatable and update

            bool isProfileChanged = false;
            DataTable oldProfileCommandsDT, newProfileCommandsDT, copyOldProfileCommandsDT, profileCommandsDT,
                copyprofileCommandsDT, copynewProfileCommandsDT;
            oldProfileCommandsDT = null;
            newProfileCommandsDT = null;
            copyOldProfileCommandsDT = null;
            profileCommandsDT = null;
            copyprofileCommandsDT = null;
            copynewProfileCommandsDT = null;

            var copyCustomCommandsDT = CustomCommandsDT.Copy();
            foreach (DataRow dr in copyCustomCommandsDT.Rows)
            {
                if (dr[Constants.Name].ToString() == oldCustomCommand.Name)
                {
                    //found the row, so update
                    if (dr[Constants.Profile].ToString() != newCustomCommand.Profile.Name)
                        isProfileChanged = true;
                    dr[Constants.Name] = newCustomCommand.Name;
                    dr[Constants.Profile] = newCustomCommand.Profile.Name;
                }
                else
                    continue;
            }
            //find profile custom command row
            if(isProfileChanged)
            {
                oldCustomCommand.Profile.CommandFilePath = GetProfileCommandPath(oldCustomCommand.Profile.Name);
                newCustomCommand.Profile.CommandFilePath = GetProfileCommandPath(newCustomCommand.Profile.Name);

                oldProfileCommandsDT = _xmlOperations.GetXml(oldCustomCommand.Profile.CommandFilePath);
                newProfileCommandsDT = _xmlOperations.GetXml(newCustomCommand.Profile.CommandFilePath);
                if (newProfileCommandsDT == null)
                    newProfileCommandsDT = GetDefaultProfileCommandDT();

                copynewProfileCommandsDT = newProfileCommandsDT.Copy();
                //add new custom command to new profile command
                DataRow newProfileCommandRow = copynewProfileCommandsDT.NewRow();
                newProfileCommandRow[Constants.Name] = newCustomCommand.Name;
                newProfileCommandRow[Constants.ActionScript] = newCustomCommand.ActionScript;
                newProfileCommandRow[Constants.Parameter] = newCustomCommand.Parameter;
                copynewProfileCommandsDT.Rows.Add(newProfileCommandRow);

                //remove from old profile command
                copyOldProfileCommandsDT = oldProfileCommandsDT.Copy();
                foreach (DataRow dataRow in copyOldProfileCommandsDT.Rows)
                {
                    if (dataRow[Constants.Name].ToString() == oldCustomCommand.Name)
                    {
                        copyOldProfileCommandsDT.Rows.Remove(dataRow);
                        break;
                    }
                }

            }
            else
            {
                oldCustomCommand.Profile.CommandFilePath = GetProfileCommandPath(oldCustomCommand.Profile.Name);

                profileCommandsDT = _xmlOperations.GetXml(oldCustomCommand.Profile.CommandFilePath);
                 copyprofileCommandsDT = profileCommandsDT.Copy();
                foreach (DataRow dr in copyprofileCommandsDT.Rows)
                {
                    if (dr[Constants.Name].ToString() == oldCustomCommand.Name)
                    {
                        dr[Constants.Name] = newCustomCommand.Name;
                        dr[Constants.ActionScript] = newCustomCommand.ActionScript;
                        dr[Constants.Parameter] = newCustomCommand.Parameter;
                    }
                    else
                        continue;
                }
            }

            //apply changes
            _xmlOperations.WriteXml(copyCustomCommandsDT, _customCommandsFilePath);
            CustomCommandsDT = copyCustomCommandsDT;
            if (copyOldProfileCommandsDT != null)
                _xmlOperations.WriteXml(copyOldProfileCommandsDT, oldCustomCommand.Profile.CommandFilePath);
            if (copynewProfileCommandsDT != null)
                _xmlOperations.WriteXml(copynewProfileCommandsDT, newCustomCommand.Profile.CommandFilePath);
            if (copyprofileCommandsDT != null)//if not profile chagnge
                _xmlOperations.WriteXml(copyprofileCommandsDT, oldCustomCommand.Profile.CommandFilePath);
            return true;
        }

        private DataTable GetDefaultProfileCommandDT()
        {
            var table = new DataTable();
            var column = new DataColumn
            {
                DataType = Type.GetType(Constants.StringType),
                ColumnName = Constants.Name
            };
            table.Columns.Add(column);

            column = new DataColumn
            {
                DataType = Type.GetType(Constants.StringType),
                ColumnName = Constants.ActionScript
            };
            table.Columns.Add(column);
            column = new DataColumn
            {
                DataType = Type.GetType(Constants.StringType),
                ColumnName = Constants.Parameter
            };
            table.Columns.Add(column);
            return table;
        }

        public bool DeleteCustomCommand(CustomCommand customCommand)
        {
            //Delete the entry from custom command file
            var copyCustomCommandsDT = CustomCommandsDT.Copy();
            foreach (DataRow dataRow in copyCustomCommandsDT.Rows)
            {
                if (dataRow[Constants.Name].ToString() == customCommand.Name)
                {
                    copyCustomCommandsDT.Rows.Remove(dataRow);
                    break;
                }
            }

            //delete from profile custom command file
            var profileCommandsDT = _xmlOperations.GetXml(customCommand.Profile.CommandFilePath);
            var copyProfileCommandsDT = profileCommandsDT.Copy();
            foreach (DataRow dataRow in copyProfileCommandsDT.Rows)
            {
                if (dataRow[Constants.Name].ToString() == customCommand.Name)
                {
                    copyProfileCommandsDT.Rows.Remove(dataRow);
                    break;
                }
            }
            _xmlOperations.WriteXml(copyCustomCommandsDT, _customCommandsFilePath);
            CustomCommandsDT = copyCustomCommandsDT;
            _xmlOperations.WriteXml(copyProfileCommandsDT, customCommand.Profile.CommandFilePath);

            return true;
        }

        public List<Profile> GetAllProfile()
        {
            return _profileManager.GetAll();
        }

        public bool UpdateProfile(Profile oldProfile, Profile newProfile)
        {
            _profileManager.Update(oldProfile, newProfile);
            var copyCustomCommandsDT = CustomCommandsDT.Copy();
            foreach (DataRow dr in copyCustomCommandsDT.Rows)
            {
                if (dr[Constants.Profile].ToString() == oldProfile.Name)
                {
                    //found the row, so update
                    dr[Constants.Profile] = newProfile.Name;
                }
                else
                    continue;
            }
            _xmlOperations.WriteXml(copyCustomCommandsDT, _customCommandsFilePath, XmlType.Profile);
            CustomCommandsDT = copyCustomCommandsDT;
            return true;
        }

        public bool AddProfile(Profile newProfile)
        {
            _profileManager.Add(newProfile);
            return true;
        }

        public bool isThisProfileExists(string newProfileName)
        {
            return _profileManager.isThisExists(newProfileName);
        }

        public bool DeleteProfile(string profileName)
        {
            //Delete the profile from profile config
            _profileManager.Delete(profileName);
            //delete the custom commands stored with that profile name
            var copyCustomCommandsDT = CustomCommandsDT.Copy();
            foreach (DataRow dataRow in copyCustomCommandsDT.Rows)
            {
                if (dataRow[Constants.Name].ToString() == profileName)
                {
                    copyCustomCommandsDT.Rows.Remove(dataRow);
                    break;
                }
            }
            _xmlOperations.WriteXml(copyCustomCommandsDT, _customCommandsFilePath,XmlType.Profile);
            CustomCommandsDT = copyCustomCommandsDT;
            return true;
        }

        public bool UpdateBuiltInCommand(string oldCommand, string newCommand, string newConfig)
        {
            return _builtInCommandManager.Update(oldCommand, newCommand, newConfig);
        }
    }
}
