using BulletHell.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BulletHell.Controller {
    class Remote : IController {

        private string id;
        public Remote(string id) {
            this.id = id;
        }
        public void UpdateLocation(GameObject obj) {
            int[] location = GameArea.Server.PlayerLocation[id];
            Debug.WriteLine("update:" + location[0] + "," + location[1]);
            obj.Location = new Point(location[0], location[1]); ;
        }
    }
}
