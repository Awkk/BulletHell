using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Network;

namespace UDP {
    class UDPSender : ISender {
        private readonly Socket mcastSocket;
        private readonly IPEndPoint endPoint;

        public UDPSender(string ipAddress, int port) {
            endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            mcastSocket = new Socket(AddressFamily.InterNetwork,
                         SocketType.Dgram,
                         ProtocolType.Udp);
        }

        public void Send(string message) {
            try {
                mcastSocket.SendTo(Encoding.ASCII.GetBytes(message), endPoint);
                Debug.WriteLine("Sent: " + message);
            } catch (Exception e) {
                Debug.WriteLine("\n" + e.ToString());
            }

            mcastSocket.Close();
        }
    }
}
