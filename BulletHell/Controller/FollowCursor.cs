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
        private GameObject obj;
        public FollowCursor(GameObject obj) {
            this.obj = obj;
        }
        public void UpdateLocation() {
            Point cursor = GameArea.MainForm.PointToClient(Control.MousePosition);
            obj.Location = new Point(cursor.X - obj.Width / 2, cursor.Y - obj.Height / 2);
        }
    }
}
