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
        public void Update(object sender, EventArgs e) {
            switch (GameArea.State) {
                case GameState.InPlay:
                    break;
                case GameState.GameOver:
                    break;
            }
        }
    }
}
