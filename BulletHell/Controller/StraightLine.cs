using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BulletHell.Model;

namespace BulletHell.Controller {
    class StraightLine : IController {
        private GameObject obj;
        private int x;
        private int y;
        public StraightLine(GameObject obj, int x, int y) {
            this.obj = obj;
            this.x = x;
            this.y = y;
        }
        public void UpdateLocation() {
            Point location = obj.Location;
            location.Offset(x, y);
            obj.Location = location;
        }
    }
}
