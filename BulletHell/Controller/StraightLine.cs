using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BulletHell.Model;

namespace BulletHell.Controller {
    class StraightLine : IController {
        private int x;
        private int y;
        public StraightLine(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public void UpdateLocation(GameObject obj) {
            Point location = obj.Location;
            location.Offset(x, y);
            obj.Location = location;
        }
    }
}
