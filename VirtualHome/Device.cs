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
        private string deviceID;
        private bool isOn;

        public Device(string name)
        {
            this.name = name;
            this.deviceID = GenerateID();
        }

        public string GenerateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        public void TurnOff()
        {
            this.isOn = false;
        }

        public void TurnOn()
        {
            this.isOn = true;
        }

        public string GetName()
        {
            return name;
        }
        public string GetDeviceId()
        {
            return deviceID;
        }
    }
}
