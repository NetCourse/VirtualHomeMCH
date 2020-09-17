using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHomeDAL
{
   public class Room
    {
        public string roomName { get; }
        public RoomType roomType { get; }
        public int Id { get; set; }
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
  
    }
}
