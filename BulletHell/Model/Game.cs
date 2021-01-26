using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulletHell.Controller;
using BulletHell.View;

namespace BulletHell.Model {
    public class Game {
        public GameObject Player { get; set; }
        private GameArea gameArea;

        public Game(GameArea gameArea) {
            this.gameArea = gameArea;
            gameArea.GameTime.Enabled = true;

            Player = new Player();
            AddGameObject(Player, new FollowCursor());
        }
        public void Start() {
            gameArea.State = GameState.InPlay;

            AddGameObject(new Bullet(this), new StraightLine(2, 2));
        }

        public void AddGameObject(GameObject obj, IController controller) {
            obj.GameArea = gameArea;
            obj.Controller = controller;
            obj.Handler = new EventHandler(obj.UpdateObject);
            gameArea.GameTime.Tick += obj.Handler;
            if (obj.GameArea.InvokeRequired) {
                return;
            }
            gameArea.Controls.Add(obj.Body);
        }

        public void GameOver() {
            gameArea.GameTime.Enabled = false;
            gameArea.State = GameState.GameOver;
        }
    }
}
