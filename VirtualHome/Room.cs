using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class Room
    {
        private string roomName;
        private List<Device> deviceList;
        private RoomType roomType;
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
            this.deviceList = new List<Device>();
        }

        public string GetRoomName()
        {
            return this.roomName;
        }
        public List<Device> GetDeviceList()
        {
            return deviceList;
        }

    }
}
