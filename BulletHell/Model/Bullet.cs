using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model {
    class Bullet : GameObject {
        public const int DefaultWidth = 10;
        public const int DefaultHeight = 10;
        public Bullet() {
            Size = new Size(DefaultWidth, DefaultHeight);
            BackColor = Color.Black;
        }
    }
}
