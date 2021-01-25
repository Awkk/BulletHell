using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network {

    public delegate void MessageRecievedHandler(object sender, string message);
    public interface IListener {
        event MessageRecievedHandler MessageRecieved;

        void ReceiveMessage();
    }
}
