using Go.Common;
using Go.Common.Entities;
using Go.Common.Interfaces;
using System.Data;
using System.IO;
using System.Xml;

namespace Go.DataAccess
{
    public class XmlOperations : IXmlOperations
    {
        public string StartupPath { get; set; }
        public XmlOperations(string appStartupPath)
        {
            StartupPath = appStartupPath;
        }
        public static bool isXmlExists(string xmlFilePath,string appPath)
        {
            return File.Exists(Utilities.GetXmlPath(xmlFilePath, appPath));
        }
        public DataTable GetXml(string xmlFilePath)
        {
            xmlFilePath = Utilities.GetXmlPath(xmlFilePath, StartupPath);
            XmlReader xmlFile = XmlReader.Create(xmlFilePath, new XmlReaderSettings());
            DataTable dataTable;
            try
            {
                using (DataSet dataSet = new DataSet())
                {
                    dataSet.ReadXml(xmlFile);
                    dataTable = dataSet.Tables[0];
                }
            }
            catch (System.Exception)
            {
                return null;
            }
            finally 
            { 
                xmlFile.Close();
            }
            return dataTable;
        }

        public bool WriteXml(DataTable dataTable, string xmlFileName, XmlType xMLType)
        {
            xmlFileName = Utilities.GetXmlPath(xmlFileName,StartupPath);
            using (DataSet dataSet = new DataSet())
            {
                dataSet.Tables.Add(dataTable);
                switch (xMLType)
                {
                    case XmlType.CustomCommand:
                        dataSet.Tables[0].TableName = "Command";
                        dataSet.DataSetName = "CustomCommands";
                        break;
                    case XmlType.BuiltInCommand:
                        dataSet.Tables[0].TableName = "BuiltInCommand";
                        dataSet.DataSetName = "BuiltInCommands";
                        break;
                    case XmlType.Profile:
                        dataSet.Tables[0].TableName = "Profile";
                        dataSet.DataSetName = "Profiles";
                        break;
                    default:
                        dataSet.Tables[0].TableName = "Command";
                        dataSet.DataSetName = "CustomCommands";
                        break;
                }
                dataSet.WriteXml(xmlFileName);
            }
            bool fileCreated = true;
            return fileCreated;
        }
    }
}
