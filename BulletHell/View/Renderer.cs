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
        public Renderer(Game game) {
            this.game = game;

            GameArea.GameTime.Tick += new EventHandler(Update);
        }
        public void Update(object sender, EventArgs e) {
            switch (game.State) {
                case GameState.InPlay:
                    break;
                case GameState.GameOver:
                    GameArea.GameTime.Enabled = false;
                    break;
            }
        }
    }
}
