using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RPGWonder.src.net
{
    internal class IPAdd
    {
        public static IPAddress GetMyIPAddress()
        {
            IPAddress ipAddr = null;
            while (ipAddr == null)
            {
                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

                foreach (NetworkInterface network in networkInterfaces)
                {
                    IPInterfaceProperties properties = network.GetIPProperties();

                    foreach (IPAddressInformation address in properties.UnicastAddresses)
                    {
                        if (address.Address.AddressFamily != AddressFamily.InterNetwork)
                            continue;

                        if (IPAddress.IsLoopback(address.Address))
                            continue;

                        if (network.Name == "Wi-Fi")
                        {
                            ipAddr = address.Address;
                        }
                    }
                }

            }
            return ipAddr;
        }
    }
}
