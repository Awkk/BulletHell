using Network;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BulletHell.Model {
    class GameClient {
        public const int MaxClients = 4;

        public ISender Sender { get; set; }
        public int[][] PlayerLocation { get; set; }
        private Game game;
        private string[] playerIds;
        private bool[] playerConnected;


        public GameClient(Game game, ISender sender) {
            this.game = game;
            Sender = sender;
            playerIds = new string[MaxClients];
            playerIds[0] = Guid.NewGuid().ToString();
            playerConnected = new bool[MaxClients];
            playerConnected[0] = true;
            PlayerLocation = new int[MaxClients][];
            for (int i = 0; i < MaxClients; i++) {
                PlayerLocation[i] = new int[2];
            }
        }

        public void ProcessMessage(string message) {
            string[] splited = message.Split(':');
            string request = splited[0];
            string senderId = splited[1];
            string location = splited[2];
            switch (request) {
                case "RequestJoin":

                    break;
                case "P":

                    break;
            }
        }

        public void SendPlayerLocation(int x, int y) {
            Debug.WriteLine("Send: " + x + "," + y);
            Sender.Send($"P:1:{x},{y}");
        }


    }
}
