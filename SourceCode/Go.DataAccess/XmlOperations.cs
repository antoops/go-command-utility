using Go.Common.Interfaces;
using System.Data;
using System.IO;
using System.Xml;

namespace Go.DataAccess
{
    class XmlOperations : IXmlOperations
    {
        public DataTable GetXml(string xmlFilePath)
        {
            string path = Directory.GetCurrentDirectory();
            xmlFilePath = xmlFilePath.Contains(":") ?
                xmlFilePath :
                path + "\\" + xmlFilePath;
            XmlReader xmlFile = XmlReader.Create(xmlFilePath, new XmlReaderSettings());
            DataTable dataTable;
            using (DataSet dataSet = new DataSet())
            {
                dataSet.ReadXml(xmlFile);
                dataTable = dataSet.Tables[0];
                xmlFile.Close();
            }
            return dataTable;
        }

        public bool WriteXml(DataTable dataTable, string xmlFileName)
        {
            string path = Directory.GetCurrentDirectory();
            xmlFileName = xmlFileName.Contains(":") ?
                xmlFileName :
                path + "\\" + xmlFileName;
            using (DataSet dataSet = new DataSet())
            {
                dataSet.Tables.Add(dataTable);
                dataSet.Tables[0].TableName = "Command";
                dataSet.DataSetName = "CustomCommands";

                dataSet.WriteXml(xmlFileName);
            }
            bool fileCreated = true;
            return fileCreated;
        }
    }
}
