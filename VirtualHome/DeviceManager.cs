using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class DeviceManager
    {
        private static DeviceManager instance;
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

      
    }
}
