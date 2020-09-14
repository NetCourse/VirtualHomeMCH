using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    abstract class Device : IDevice
    {
        private string name;
        private int deviceID;
        private bool isOn;
        public void TurnOff()
        {
            this.isOn = false;
        }

        public void TurnOn()
        {
            this.isOn = true;
        }
    }
}
