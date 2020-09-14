using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Room entrance = new Room("Entrance hallway");
            Room livingroom = new Room("Livingroom");
            Room kitchen = new Room("Kitchen");
            Room smallBedroom = new Room("Jacks edroom");
            Room bigBedroom = new Room("Bobs bedroom");
            Room office = new Room("Office");
            Room toilet = new Room("Toilet");
            Room bathroom = new Room("Bathroom");

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
