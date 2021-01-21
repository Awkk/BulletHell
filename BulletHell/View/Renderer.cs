using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulletHell.Model;

namespace BulletHell.View {
    class Renderer {
        private Game game;
        private Timer gameTime;
        public Renderer(Game game) {
            this.game = game;
            gameTime = new Timer {
                Interval = 1
            };
            gameTime.Tick += new EventHandler(Update);
        }
        public void Start() {
            gameTime.Start();
        }
        public void Stop() {
            gameTime.Stop();
        }
        public void Update(object sender, EventArgs e) {
            switch (game.State) {
                case GameState.InPlay:
                    GameArea.MainForm.Invalidate();
                    foreach (GameObject player in game.Players) {
                        player.Controller.UpdateLocation();
                    }
                    foreach (GameObject bullet in game.Bullets) {
                        bullet.Controller.UpdateLocation();
                        foreach (GameObject player in game.Players) {
                            if (GameLogic.Collision(player, bullet)) {
                                game.State = GameState.GameOver;
                            }
                            if (GameLogic.OutOfBorder(bullet)) {
                                GameArea.MainForm.Controls.Remove(bullet.Body);
                                
                                Debug.WriteLine("removed");
                            }
                        }
                    }
                    break;
                case GameState.GameOver:
                    Stop();
                    break;
            }
        }
    }
}
