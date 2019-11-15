using System.Data;

namespace Go.Common.Interfaces
{
    public interface IXmlOperations
    {
        DataTable GetXml(string xmlFilePath);
        bool WriteXml(DataTable dataTable, string xmlFileName, Entities.XmlType xMLType = Entities.XmlType.CustomCommand);
    }
}
