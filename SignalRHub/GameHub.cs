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
            //app.MapSignalR();
            app.MapAzureSignalR(this.GetType().FullName);
        }
    }
    [HubName("GameHub")]
    public class MyHub : Hub {

        public void Broadcast(string message) {
            Console.WriteLine(message);
            Clients.All.addMessage(message);
        }
    }
}
