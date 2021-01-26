using System.Drawing;
using System.Windows.Forms;

namespace BulletHell.Model {
    public class Player : GameObject {
        public const int DefaultWidth = 20;
        public const int DefaultHeight = 20;
        public Player() {
            Size = new Size(DefaultWidth, DefaultHeight);
            BackColor = Color.Chocolate;
        }
    }
}
