
namespace Go.Common
{
    public class Utilities
    {
        static public string GetXmlPath(string xmlFilePath, string startupPath)
        {
            xmlFilePath = xmlFilePath.Contains(":") ?
                xmlFilePath :
                startupPath + "\\" + xmlFilePath;
            return xmlFilePath;
        }
    }
}
