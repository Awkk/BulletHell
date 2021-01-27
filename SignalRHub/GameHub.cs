using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRHub {
    class GameHub {
        static void Main(string[] args) {
            string url = @"http://localhost:8080/";
            using (WebApp.Start<Startup>(url)) {
                Console.WriteLine(string.Format("Server running at {0}", url));
                Console.ReadLine();
            }
        }
    }

    class Startup {
        public void Configuration(IAppBuilder app) {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
    [HubName("GameHub")]
    public class MyHub : Hub {

        public void Broadcast(string message) {
            Console.WriteLine(message);
            Clients.All.addMessage(message);
        }
        public void Send(string name, string message) {
            Clients.All.addMessage(name, message);
        }

        public void DetermineLength(string message) {
            Console.WriteLine(message);
            string newMessage = string.Format(@"{0} has a length of: {1}", message, message.Length);
            Clients.All.ReceiveLength(newMessage);
        }
    }
}
