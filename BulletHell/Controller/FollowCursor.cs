﻿using System;
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
            Point cursor = obj.GameArea.PointToClient(Control.MousePosition);
            int newX = (cursor.X - obj.Width / 2 < 0) || (cursor.X + obj.Width > obj.GameArea.Width) ? obj.Location.X : cursor.X - obj.Width / 2;
            int newY = (cursor.Y - obj.Height / 2 < 0) || (cursor.Y + obj.Height*1.75 > obj.GameArea.Height) ? obj.Location.Y : cursor.Y - obj.Height / 2;
            obj.Location = new Point(newX, newY);
            obj.GameArea.Server.SendPlayerLocation(newX, newY);
        }
    }
}
