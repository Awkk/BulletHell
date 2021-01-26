using BulletHell.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BulletHell.Controller {
    class BounceOffWall : IController {

        private int x;
        private int y;
        public BounceOffWall(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public void UpdateLocation(GameObject obj) {
            Point location = obj.Location;
            if (location.X - obj.Width / 2 < 0 || location.X + obj.Width * 2 > obj.GameArea.Width) {
                x = -x;
            }
            if (location.Y - obj.Height / 2 < 0 || location.Y + obj.Height * 5 > obj.GameArea.Height) {
                y = -y;
            }
            location.Offset(x, y);
            obj.Location = location;
        }
    }
}
