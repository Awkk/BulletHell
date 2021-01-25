using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Multicast {
    public class MulticastListener {
        private readonly Socket mcastSocket;

        public MulticastListener(string ipAddress, int port) {
            try {
                mcastSocket = new Socket(AddressFamily.InterNetwork,
                                         SocketType.Dgram,
                                         ProtocolType.Udp);

                IPAddress mcastAddress = IPAddress.Parse(ipAddress);
                IPAddress localIP = IPAddress.Any;
                EndPoint localEP = new IPEndPoint(localIP, port);

                mcastSocket.Bind(localEP);

                MulticastOption mcastOption = new MulticastOption(mcastAddress, localIP);

                mcastSocket.SetSocketOption(SocketOptionLevel.IP,
                                            SocketOptionName.AddMembership,
                                            mcastOption);
            } catch (Exception e) {
                Debug.WriteLine(e.ToString());
            }
        }

        public void ReceiveMessage() {
            bool done = false;
            byte[] bytes = new byte[100];
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            try {
                while (!done) {
                    mcastSocket.ReceiveFrom(bytes, ref remoteEP);
                    OnMessageReceived(Encoding.ASCII.GetString(bytes, 0, bytes.Length));
                }

                mcastSocket.Close();
            } catch (Exception e) {
                Debug.WriteLine(e.ToString());
            }
        }

        public delegate void MessageRecievedHandler(object sender, string message);

        public event MessageRecievedHandler MessageRecieved;

        protected virtual void OnMessageReceived(string message) {
            MessageRecieved?.Invoke(this, message);
        }
    }
}
