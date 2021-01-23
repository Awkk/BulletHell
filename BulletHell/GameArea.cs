using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulletHell.Model;
using BulletHell.View;


namespace BulletHell {
    public partial class GameArea : Form {
        public static GameArea MainForm { get; private set; }
        public static Timer GameTime { get; private set; }

        public const int GameAreaWidth = 720;
        public const int GameAreaHeight = 720;
        public GameArea() {
            MainForm = this;
            Height = GameAreaHeight;
            Width = GameAreaWidth;
            StartPosition = FormStartPosition.CenterScreen;

            GameTime = new Timer {
                Interval = 1,
                Enabled = true
            };

            Game game = new Game();
            Renderer renderer = new Renderer(game);
        }
    }
}
