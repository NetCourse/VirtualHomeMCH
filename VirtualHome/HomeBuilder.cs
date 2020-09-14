using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class HomeBuilder
    {
        public static void Main(String args[])
        {
            Home myHome = new Home();
            Person myHomeOwner = new Person("Bob");
            myHome.SetOwner(myHomeOwner);
            Person jack = new Person("Jack");
            Person maggie = new Person("Maggie");

            myHome.GetGuests().Add(jack);
            myHome.GetGuests().Add(maggie);
   
        }
    }

}
