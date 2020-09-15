using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class Room
    {
        public string roomName { get; }
        private RoomType roomType { get; }

        static DeviceManager deviceManager = DeviceManager.GetInstance();
        public enum RoomType
        {
            Attic,
            Loft,
            Bedroom,
            Bathroom,
            Balcony,
            Utilityroom,
            Panicroom,
            Livingroom,
            Diningroom,
            Kitchen,
            Garage,
            Cellar,
            Mancave,
            Hallway,
            Office,
            Toilet
        }

        public Room(string roomName, RoomType roomType)
        {
            this.roomName = roomName;
            this.roomType = roomType;
        }
        public IEnumerable<Device> Devices()
        {
            //ogarnąc xunit
            //zwróc wyrażenie. Jesli puste to zwróc pustą kolekcje
            var temp = deviceManager.devices.Where(device => device.location == this);
            return temp;
        }
    }
}
