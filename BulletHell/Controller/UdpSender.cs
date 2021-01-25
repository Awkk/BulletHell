using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulletHell.Model;

namespace BulletHell.Controller {
    class UdpSender : IController {

        private Guid guid;
        private IController controller;

        public UdpSender(IController controller) {
            this.controller = controller;
            guid = Guid.NewGuid();
        }
        
        public void UpdateLocation(GameObject obj) {
            controller.UpdateLocation(obj);

        }
    }
}
