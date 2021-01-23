using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulletHell.Controller;
using BulletHell.View;

namespace BulletHell.Model {
    class Game {
        public GameState State { get; set; }
        public GameObject Player { get; private set; }

        public Game() {
            Reset();
        }
        public void Reset() {
            State = GameState.InPlay;
            Player = new Player();

            AddGameObject(Player, new FollowCursor());
            AddGameObject(new Bullet(this), new StraightLine(1, 1));
        }

        public void AddGameObject(GameObject obj, IController controller) {
            obj.Controller = controller;
            GameArea.MainForm.Controls.Add(obj.Body);
            GameArea.GameTime.Tick += new EventHandler(obj.UpdateObject);
        }

        public void GameOver() {
            State = GameState.GameOver;
        }
    }
}
