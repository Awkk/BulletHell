using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BulletHell.Model {
    class Bullet : GameObject {
        public const int DefaultWidth = 10;
        public const int DefaultHeight = 10;

        private readonly Game game;
        public Bullet(Game game) {
            Size = new Size(DefaultWidth, DefaultHeight);
            BackColor = Color.Firebrick;
            this.game = game;
        }

        public override void UpdateObject(object sender, EventArgs e) {
            base.UpdateObject(sender, e);
            if (GameLogic.Collision(this, game.Player)) {
                game.GameOver();
            }
/*            if (GameLogic.OutOfBorder(this)) {
                GameArea.Controls.Remove(Body);
                GameArea.GameTime.Tick -= Handler;
            }*/
        }
    }
}
