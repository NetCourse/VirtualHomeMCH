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
        }

        public string GetRoomName()
        {
            return this.roomName;
        }

    }
}
