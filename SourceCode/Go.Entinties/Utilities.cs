using System.IO;

namespace Go.Common
{
    public class Utilities
    {
        static public string GetXmlPath(string xmlFilePath)
        {
            string path = Directory.GetCurrentDirectory();
            xmlFilePath = xmlFilePath.Contains(":") ?
                xmlFilePath :
                path + "\\" + xmlFilePath;
            return xmlFilePath;
        }
    }
}
