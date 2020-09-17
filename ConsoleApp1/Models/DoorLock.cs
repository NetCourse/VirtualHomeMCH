using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHomeDAL
{
    public class DoorLock 
    {
        public string name { get; set; }
        public int Id { get; set; }
        public bool isOn { get; set; }

        public Room location { get; set; }

        public bool isLocked = false;
   
    }
}
