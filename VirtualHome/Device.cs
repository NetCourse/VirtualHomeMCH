using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    abstract class Device : IDevice
    {
        public string name { get; private set; }
        public Guid deviceID { get; }
        public bool isOn { get; private set; }

        public Room location { get; private set; }


        public Device(string name)
        {
            this.name = name;
            this.deviceID = Guid.NewGuid();
        }

        public void AssignTo(Room room)
        {
            location = room;
        }

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
