using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class DeviceManager
    {
        private static DeviceManager instance = new DeviceManager();
        public IList<Device> devices = new List<Device>();
        private DeviceManager()
        {

        }

        public static DeviceManager GetInstance()
        {
            if (instance == null)
            {
                instance = new DeviceManager();
            }
            return instance;
        }

        public void AssignDevice(Room room, Device device)
        {
            devices.Add(device);
            device.AssignTo(room);
        }

        public T GetDevice<T>(string deviceName) where T : Device
        {
            var deviceList = devices.Where(device => device.name.Equals(deviceName));
            if (devices.Count() > 1)
            {
                // Handle error
                Console.WriteLine("Multiple devices found. Only first return. Please try to specify the room");
            }
            return devices.FirstOrDefault() as T;
        }
        public T GetDevice<T>(string deviceName, string roomName) where T : Device
        {
            var deviceList = devices.Where(device => device.name.Equals(deviceName) && device.location.roomName == roomName);
            if (devices.Count() > 1)
            {
                // Handle error
                Console.WriteLine($"In {roomName} multiply devices found. Cannot handle.");
            }
            return devices.FirstOrDefault() as T;
        }
    }
}
