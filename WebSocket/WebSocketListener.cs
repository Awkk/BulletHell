using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using Microsoft.AspNet.SignalR.Client;

namespace WebSocket {
    public class WebSocketListener : IListener {
        public event MessageRecievedHandler MessageRecieved;
        public bool Done { get; set; }

        private IHubProxy hubProxy;

        public WebSocketListener(IHubProxy hubProxy) {
            this.hubProxy = hubProxy;
        }

        public void ReceiveMessage() {
            hubProxy.On("addMessage", message => OnMessageReceived(message));
        }

        protected virtual void OnMessageReceived(string message) {
            MessageRecieved?.Invoke(this, message);
        }
    }
}
