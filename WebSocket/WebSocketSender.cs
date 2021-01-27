using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using Network;

namespace WebSocket {
    public class WebSocketSender : ISender {
        private IHubProxy hubProxy;
        public WebSocketSender(IHubProxy hubProxy) {
            this.hubProxy = hubProxy;
        }

        public void Send(string message) {
            hubProxy.Invoke("Broadcast", message);
        }
        public void Close() {

        }
    }
}
