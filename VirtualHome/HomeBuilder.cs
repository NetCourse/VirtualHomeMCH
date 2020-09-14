using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *
-  inject device manager to room (receive room devices via room object. Devices has ref to room)
-  create generic method to get device any type
-  create class resident (for routines, delegates, event)
*/
namespace VirtualHome
{
    class HomeBuilder
    {
        public static void Main(String[] args)
        {
           

            // Pepole creation
            Person bob = new Person("Bob");
            Person jack = new Person("Jack");
            Person maggie = new Person("Maggie");

            // Home creation
            Home myHome = new Home("Batcave");

            // Rooms creation
            Room entrance = new Room("Entrance hallway",Room.RoomType.Hallway);
            Room livingroom = new Room("Livingroom", Room.RoomType.Livingroom);
            Room kitchen = new Room("Kitchen", Room.RoomType.Kitchen);
            Room smallBedroom = new Room("Jacks edroom", Room.RoomType.Bedroom);
            Room bigBedroom = new Room("Bobs and Maggies bedroom", Room.RoomType.Bedroom);
            Room office = new Room("Office",Room.RoomType.Office);
            Room toilet = new Room("Toilet", Room.RoomType.Toilet);
            Room bathroom = new Room("Bathroom",Room.RoomType.Bathroom);

            // Rooms addition

            myHome.GetRooms().Add(entrance);
            myHome.GetRooms().Add(livingroom);
            myHome.GetRooms().Add(kitchen);
            myHome.GetRooms().Add(smallBedroom);
            myHome.GetRooms().Add(bigBedroom);
            myHome.GetRooms().Add(office);
            myHome.GetRooms().Add(toilet);
            myHome.GetRooms().Add(bathroom);

            // Adding devices
            entrance.GetDeviceList().Add(new Light(Light.Color.White, "Led stripe"));
            livingroom.GetDeviceList().Add(new Light(Light.Color.White, "Chandelier"));
            livingroom.GetDeviceList().Add(new Light(Light.Color.White, "Reading Lamp"));
            livingroom.GetDeviceList().Add(new TV("Samsung QDWG75"));
            livingroom.GetDeviceList().Add(new AirConditioner("AC", "LG K343"));
            kitchen.GetDeviceList().Add(new AirConditioner("AC", "LG K343"));
            kitchen.GetDeviceList().Add(new Light(Light.Color.White, "Antibacterial UV light"));
            smallBedroom.GetDeviceList().Add(new Light(Light.Color.White, "Led stripe"));
            smallBedroom.GetDeviceList().Add(new Laptop("Private laptop", "Acer", "NitroQ980"));
            bigBedroom.GetDeviceList().Add(new TV("Samsung QDWG75"));
            bigBedroom.GetDeviceList().Add(new AirConditioner("AC", "LG K343"));
            office.GetDeviceList().Add(new Laptop("Company laptop", "Lenovo", "Thinkpad T480"));
            office.GetDeviceList().Add(new Light(Light.Color.White, "Led stripe"));
            office.GetDeviceList().Add(new TV("Samsung QDWG65"));
            toilet.GetDeviceList().Add(new Light(Light.Color.White, "Antibacterial UV light"));
            toilet.GetDeviceList().Add(new Light(Light.Color.White, "Led stripe"));
            bathroom.GetDeviceList().Add(new Light(Light.Color.White, "Led stripe"));
            bathroom.GetDeviceList().Add(new AirConditioner("AC", "LG K343"));

            //Assigning owner/guests
            Person myHomeOwner = bob;
            myHome.SetOwner(myHomeOwner);
            myHome.GetGuests().Add(jack);
            myHome.GetGuests().Add(maggie);

            // Adding Accesses
            myHomeOwner.SetAccess(new Access(myHome));
            myHomeOwner.GetAccess().AddAccessToAllRooms();
            jack.SetAccess(new Access(myHome));
            jack.GetAccess().AddAccessToAllRooms();
            maggie.SetAccess(new Access(myHome));
            maggie.GetAccess().AddAccessToAllRooms();
            jack.GetAccess().RevokeAccess("Office");
            maggie.GetAccess().RevokeAccess("Office");

        }
    }

}
