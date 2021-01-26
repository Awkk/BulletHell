using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using BulletHell.Controller;
using System.Diagnostics;
using System.Drawing;

namespace BulletHell.Model {

    public class GameServer {
        public ISender Sender { get; set; }
        private Game game;
        public Dictionary<string, int[]> PlayerLocation { get; set; }
        private string id;
        private int i = 0;

        private Random rnd;

        public GameServer(Game game, ISender sender) {
            this.game = game;
            Sender = sender;
            id = Guid.NewGuid().ToString();
            PlayerLocation = new Dictionary<string, int[]>();
            rnd = new Random();
        }

        public void ProcessMessage(string message) {
            string[] splited = message.Split(':');
            string request = splited[0];
            string senderId = splited[1];
            string location = splited[2];
            switch (request) {
                case "P":
                    if (senderId != id) {
                        Debug.WriteLine("\n" + i++ + ": " + message + "\n");
                        string[] xy = location.Split(',');
                        if (!PlayerLocation.ContainsKey(senderId)) {
                            Player player = new Player();
                            player.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                            PlayerLocation[senderId] = new int[] { int.Parse(xy[0]), int.Parse(xy[1]) };
                            game.AddGameObject(player, new Remote(senderId));
                        } else {
                            PlayerLocation[senderId] = new int[] { int.Parse(xy[0]), int.Parse(xy[1]) };
                        }
                    }
                    break;
                case "Start":
                    game.Start();
                    break;
                case "GameOver":
                    game.GameArea.GameTime.Enabled = false;
                    game.GameArea.StopWatch.Stop();
                    game.ShowDeathControlVisible();
                    break;
            }
        }
        public void SendPlayerLocation(int x, int y) {
            // Debug.WriteLine("Send: " + x + "," + y);
            Sender.Send($"P:{id}:{x},{y}");
        }
        public void SendGameStart() {
            Sender.Send("Start:0:0,0");
        }
        public void SendGameOver() {
            Sender.Send("GameOver:0:0,0");
        }

    }
}
