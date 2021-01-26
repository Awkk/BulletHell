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
    public class UDPListener : IListener {
        private UdpClient udpclient;
        public static bool Done { get; set; }
        public UDPListener(string ipAddress, int port) {
            try {

                IPAddress mcastAddress = IPAddress.Parse(ipAddress);
                IPAddress localIP = IPAddress.Any;
                EndPoint localEP = new IPEndPoint(localIP, port);

                udpclient = new UdpClient();
                udpclient.ExclusiveAddressUse = false;
                udpclient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpclient.ExclusiveAddressUse = false;
                udpclient.Client.Bind(localEP);
                udpclient.JoinMulticastGroup(mcastAddress, localIP);
            } catch (Exception e) {
                Debug.WriteLine(e.ToString());
            }
        }

        public void ReceiveMessage() {
            Done = false;
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            try {
                while (!Done) {
                    byte[] bytes = udpclient.Receive(ref remoteEP);
                    //Debug.WriteLine("\n" + Encoding.ASCII.GetString(bytes, 0, bytes.Length) + "\n");
                    OnMessageReceived(Encoding.ASCII.GetString(bytes, 0, bytes.Length));
                }
            } catch (Exception e) {
                Debug.WriteLine(e.ToString());
            } finally {
                udpclient.Close();
            }
        }

        public event MessageRecievedHandler MessageRecieved;

        protected virtual void OnMessageReceived(string message) {
            MessageRecieved?.Invoke(this, message);
        }
    }
}
