using Go.Common.Entities;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Go.Common.BuiltInCommands
{
    public class GetMyIP : BuiltInCommand
    {
        public override bool Execute(string nestedParameter)
        {
            try
            {
                IPHostEntry host;
                string myIP = "?";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        myIP = ip.ToString();
                    }
                }
                Clipboard.SetText(myIP);
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }
    }
}
