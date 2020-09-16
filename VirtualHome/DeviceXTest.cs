using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VirtualHome
{
    public class DeviceXTest
    {
        [Fact]
        public void TurnOn_Changing_IsOn_Should_Be_True()
        {
            var laptop = new Laptop("Test", "Test", "Test");
            laptop.TurnOn();
            Assert.True(laptop.isOn);
        }
        // metoda akcja rezultat
        [Fact]
        public void TurnOff_IsON_Should_Be_False()
        {
            var laptop = new Laptop("Test", "Test", "Test");
            laptop.TurnOff();
            Assert.False(laptop.isOn);
        }
        [Fact]
        public void AssignTo_location_Should_be_location()
        {
            var room = new Room("test", Room.RoomType.Bedroom);
            var light = new Light(Light.Color.Orange, "test light");
            light.AssignTo(room);
            Assert.Equal(room, light.location);
        }
        [Fact]
        public void GetDevice_device_Should_Return_Device()
        {
            var tv = new TV("test");
            var deviceManager = DeviceManager.GetInstance();
            var room = new Room("test room", Room.RoomType.Cellar);
            deviceManager.AssignDevice(room, tv);
            var device = deviceManager.GetDevice<Device>("test","test room");
            Assert.Equal(tv, device);
        }
    }
}
