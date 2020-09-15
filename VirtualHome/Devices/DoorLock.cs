using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class DoorLock : Device
    {

        private bool isLocked = false;
        public DoorLock(string name) : base (name)
        {

        }

        public void Lock()
        {
            isLocked = true;
            Console.WriteLine("{0} has been locked", name);
        }

        public void UnLock()
        {
            if (isLocked == false)
            {
                Console.WriteLine("{0} is already unlocked", name);
            }
            else
            {
                isLocked = false;
                Console.WriteLine("{0} has been unlocked", name);
            }
        }
    }
}
