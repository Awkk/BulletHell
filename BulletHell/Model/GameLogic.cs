using BulletHell.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BulletHell.Model {
    class GameLogic {
        public static bool Collision(GameObject obj1, GameObject obj2) {
            return obj1.Bounds.IntersectsWith(obj2.Bounds);
        }
        public static bool OutOfBorder(GameObject obj) {
            Point location = obj.Location;
            return location.X < 0 || location.Y < 0 ||
                location.X > GameArea.MainForm.Width ||
                location.Y > GameArea.MainForm.Height;
        }
    }
}
