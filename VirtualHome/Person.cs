using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class Person
    {
        private string name;
        private List<Room> access;

        public Person(string name)
        {
            access = new List<Room>();
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void AddAccess(string roomName)
        {

         //   bool ist = access.Find(x => x.GetRoomName() == "res");

            /*
            if (access.IndexOf(roomName)== -1)
            {
                this.access.Add(roomName);
            }
            else
            {
                Console.WriteLine("Access to {0} has already been granted", roomName);
            }
            */
        }
        public void RemoveAccess(string roomName)
        {

        }
    }
}
