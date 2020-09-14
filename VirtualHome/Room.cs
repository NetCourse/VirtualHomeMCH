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
        enum RoomType
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
            Corridor
        }

        public Room(string roomName)
        {
            this.roomName = roomName;
            this.deviceList = new List<Device>();
        }

        public string GetRoomName()
        {
            return this.roomName;
        }

    }
}
