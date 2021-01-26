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

        public Game() {
            GameArea.GameTime.Enabled = true;

            Player = new Player();
            AddGameObject(Player, new FollowCursor());
        }
        public void Start() {
            GameArea.State = GameState.InPlay;

            AddGameObject(new Bullet(this), new StraightLine(2, 2));
        }

        public void AddGameObject(GameObject obj, IController controller) {
            obj.Controller = controller;
            obj.Handler = new EventHandler(obj.UpdateObject);
            GameArea.GameTime.Tick += obj.Handler;
            GameArea.MainForm.Controls.Add(obj.Body);
        }

        public void GameOver() {
            GameArea.GameTime.Enabled = false;
            GameArea.State = GameState.GameOver;
        }
    }
}
