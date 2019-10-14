using Go.Common.Entities;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Go.Common.BuiltInCommands
{
    public class GetMyMAC : BuiltInCommand
    {
        public override bool Execute(string nestedParameter)
        {
            try
            {
                string macAddress = string.Empty;
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus == OperationalStatus.Up)
                    {
                        macAddress += nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }
                Clipboard.SetText(macAddress);
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }
    }
}
