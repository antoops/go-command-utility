using Go.Common;
using Go.Common.Entities;
using Go.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Go.DataAccess
{
    public class BuiltInCommandManager : IBuiltInCommandManager
    {
        private readonly IXmlOperations _xmlOperations;
        private readonly string _builtInCommandPath;

        public DataTable BuiltInCommandDT{ get; set; }

        public BuiltInCommandManager(string builtInCommandPath, string applicationStartupPath)
            : this(new XmlOperations(applicationStartupPath), builtInCommandPath, applicationStartupPath)
        {

        }
        public BuiltInCommandManager(IXmlOperations xmlOperations, string builtInCommandPath,
            string applicationStartupPath)
        {
            _xmlOperations = xmlOperations;
            builtInCommandPath = applicationStartupPath + "\\" + builtInCommandPath;
            _builtInCommandPath = builtInCommandPath;
            BuiltInCommandDT = _xmlOperations.GetXml(builtInCommandPath);
        }


        public bool isThisExists(string commandName)
        {
            DataView builtInCommandsDT = new DataView(BuiltInCommandDT)
            {
                Sort = "Name"
            };

            int builtInCommandIndex = builtInCommandsDT.Find(commandName);

            if (builtInCommandIndex == -1)
                return false;
            return true;
        }

        public DataTable GetBuiltInCommandDT()
        {
            return BuiltInCommandDT;
        }


        public BuiltInCommand Get(string cmdName)
        {
            //1. Find the profile of the given command
            DataView builtInCommandsDV = new DataView(BuiltInCommandDT)
            {
                Sort = "Name"
            };

            int builtInCommandIndex = builtInCommandsDV.Find(cmdName);
            if (builtInCommandIndex != -1)
            {
                var ActionScript = builtInCommandsDV[builtInCommandIndex]["ActionScript"].ToString();
                var Parameter = builtInCommandsDV[builtInCommandIndex]["Parameter"].ToString();
               
                var type = Type.GetType("Go.Common.BuiltInCommands." + ActionScript + ", Go.Common");
                var newBuiltInCommand = (BuiltInCommand)Activator.CreateInstance(type);
                newBuiltInCommand.Configuration = Parameter;
                return newBuiltInCommand;
              
            }
            return null;
        }

        public bool Update(string oldCommand,  string newCommand, string newParameter)
        {
            var copyBuiltInCommandDT = BuiltInCommandDT.Copy();
            foreach (DataRow dr in copyBuiltInCommandDT.Rows)
            {
                if (dr[Constants.Name].ToString() == oldCommand)
                {
                    dr[Constants.Name] = newCommand;
                    dr[Constants.Parameter] = newParameter;
                }
                else
                    continue;
            }
           
            //write to xml file
            _xmlOperations.WriteXml(copyBuiltInCommandDT, _builtInCommandPath,XmlType.BuiltInCommand);
            BuiltInCommandDT = copyBuiltInCommandDT;
            return true;
        }

        public List<string> GetNames()
        {
            List<string> lstBuiltInCommands = new List<string>();
            foreach (DataRow dr in BuiltInCommandDT.Rows)
            {
                lstBuiltInCommands.Add(dr["Name"].ToString());
            }
            return lstBuiltInCommands;
        }
    }
}
