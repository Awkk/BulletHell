using System.Drawing;
using System.Windows.Forms;

namespace BulletHell.Model {
    class Player : GameObject {
        public const int DefaultWidth = 30;
        public const int DefaultHeight = 30;
        public Player() {
            Size = new Size(DefaultWidth, DefaultHeight);
            BackColor = Color.Brown;
        }
    }
}
