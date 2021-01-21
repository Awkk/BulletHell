using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulletHell.Controller;

namespace BulletHell.Model {
    class Game {
        public GameState State { get; set; }
        public ArrayList Players { get; private set; }
        public ArrayList Bullets { get; private set; }

        public Game() {
            Reset();
        }
        public void Reset() {
            State = GameState.InPlay;
            Players = new ArrayList();
            Bullets = new ArrayList();

            Player player = new Player();
            player.Controller = new FollowCursor(player);
            Players.Add(player);
            GameArea.MainForm.Controls.Add(player.Body);

            Bullet bullet = new Bullet();
            bullet.Controller = new StraightLine(bullet, 1, 1);
            Bullets.Add(bullet);
            GameArea.MainForm.Controls.Add(bullet.Body);
        }
    }
}
