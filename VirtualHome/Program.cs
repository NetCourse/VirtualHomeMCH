using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class Program
    {

        public static void Main(string[] arsg)
        {
            DeviceManager deviceManager = DeviceManager.GetInstance();

            var home = BuildHome.CreateHome();

            BuildHome.EquipAllRooms(home, "light");
            BuildHome.EquipAllRooms(home, "doorlock");
            BuildHome.EquipAllRooms(home, "airconditioner");

            deviceManager.AssignDevice(home.FirstOrDefault(room => room.roomName.Equals("Office")), new Laptop("Private Laptop","Lenovo","T480"));
        }
    }
}
