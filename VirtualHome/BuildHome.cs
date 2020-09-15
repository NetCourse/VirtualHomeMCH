using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    static class BuildHome
    {
        public static List<Room> CreateHome()
        {
            var home = new List<Room>();

            home.Add(new Room("Entrance hallway", Room.RoomType.Hallway));
            home.Add(new Room("Livingroom", Room.RoomType.Livingroom));
            home.Add(new Room("Kitchen", Room.RoomType.Kitchen));
            home.Add(new Room("Jacks bedroom", Room.RoomType.Bedroom));
            home.Add(new Room("Bobs and Maggies bedroom", Room.RoomType.Bedroom));
            home.Add(new Room("Office", Room.RoomType.Office));
            home.Add(new Room("Toilet", Room.RoomType.Toilet));
            home.Add(new Room("Bathroom", Room.RoomType.Bathroom));

            return home;
        }
        public static void EquipAllRooms(List<Room> home, string deviceType)
        {
            DeviceManager deviceManager = DeviceManager.GetInstance();
            foreach (Room room in home)
            {
                switch (deviceType.ToLower())
                {
                    case "tv": { deviceManager.AssignDevice(room, new TV($"{room.roomName} tv")); break; }
                    case "light": { deviceManager.AssignDevice(room, new Light(Light.Color.White,$"{room.roomName} light")); break; }
                    case "doorlock": { deviceManager.AssignDevice(room, new DoorLock($"{room.roomName} doorlock")); break; }
                    case "airconditioner": { deviceManager.AssignDevice(room, new AirConditioner($"{room.roomName} airconditioner", "Toshiba B230")); break; }
                    default: throw new ArgumentException($"{deviceType} type not recognized");
                }


            }
        }
    }
}
