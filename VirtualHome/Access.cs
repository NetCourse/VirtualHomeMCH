using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
     
    class Access
    {
        private List<Room> access;
        private Home home;

        public Access(Home home)
        {
            this.home = home;
            access = new List<Room>();
        }

        public void AddAccessToAllRooms()
        {
            access = new List<Room>(home.GetRooms());
        }

        public void AddAccessToRoom(Room room)
        {
            if (home.GetRooms().Any(x => x.Equals(room)))
            {
                if (access.Any(x => x.Equals(room)))
                {
                    Console.WriteLine("Access to {0} in {1} is already on the accessible rooms list.", room.GetRoomName(), home.GetHomeName());
                }
                else
                {
                    access.Add(room);
                    Console.WriteLine("Access to {0} in {1}, has been granted.", room.GetRoomName(), home.GetHomeName());
                }
            }
            else
            {
                Console.WriteLine("There is no {0} in {1}.", room.GetRoomName(), home.GetHomeName());
            }
        }
        public void AddAccessToRoom(string roomName)
        {

            if (home.GetRooms().Any(x => x.GetRoomName().Equals(roomName)))
            {
                if (access.Any(x => x.GetRoomName().Equals(roomName)))
                {
                    Console.WriteLine("Access to {0} in {1} is already on the accessible rooms list.", roomName, home.GetHomeName());
                }
                else
                {
                    access.Add(home.GetRooms().Find(x => x.GetRoomName().Equals(roomName)));
                    Console.WriteLine("Access to {0} in {1}, has been granted.", roomName, home.GetHomeName());
                }
            }
            else
            {
                Console.WriteLine("There is no {0} in {1}.", roomName, home.GetHomeName());
            }
            
        }
        public void RevokeAccess(string roomName)
        {
            if (access.Any(x => x.GetRoomName().Equals(roomName)))
            {
                access.Remove(access.Find(x => x.GetRoomName().Equals(roomName)));
                Console.WriteLine("Access to {0} in {1} has been revoked.", roomName, home.GetHomeName());
            }
            else
            {
               Console.WriteLine("{0} in {1} was already not accessible.", roomName, home.GetHomeName());
            }
        }

        public void RevokeAccess(Room room)
        {
            if (access.Any(x => x.GetRoomName().Equals(room)))
            {
                access.Remove(room);
            }
        }

    }
}
