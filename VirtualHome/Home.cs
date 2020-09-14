﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{

    class Home
    {
        private List<Room> rooms;
        private List<Person> guests;
        private Person owner;
        private string homeName;

        public Home(string homeName)
        {
            this.homeName = homeName;
            guests = new List<Person>();
            rooms = new List<Room>();
        }

        public List<Person> GetGuests()
        {
            return this.guests;
        }
        public List<Room> GetRooms()
        {
            return this.rooms;
        }
        public Person GetOwner()
        {
            return this.owner;
        }
        public void SetOwner(Person person)
        {
            this.owner = person;
        }
        public string GetHomeName()
        {
            return homeName;
        }
        public void SetHomeName(string homeName)
        {
            this.homeName = homeName;
        }

    }

}
