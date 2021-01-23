using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using BulletHell.Model;

namespace BulletHell.Controller {
    class FollowCursor : IController {
        public void UpdateLocation(GameObject obj) {
            Point cursor = GameArea.MainForm.PointToClient(Control.MousePosition);
            int newX = (cursor.X - obj.Width / 2 < 0) || (cursor.X + obj.Width > GameArea.MainForm.Width) ? obj.Location.X : cursor.X - obj.Width / 2;
            int newY = (cursor.Y - obj.Height / 2 < 0) || (cursor.Y + obj.Height*1.75 > GameArea.MainForm.Height) ? obj.Location.Y : cursor.Y - obj.Height / 2;
            obj.Location = new Point(newX, newY);
        }
    }
}
