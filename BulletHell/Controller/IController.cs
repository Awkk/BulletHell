using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulletHell.Model;

namespace BulletHell.Controller {
    interface IController {
        void UpdateLocation(GameObject obj);
    }
}
