using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class TV : Device
    {
        private int channel;
        public TV(string name) : base(name)
        {
            channel = 0;
        }
        public void SetChannel(int channel)
        {
            if (channel > 0 && channel < 999)
            {
                this.channel = channel;
            }
        }
        public int GetChannel()
        {
            return channel;
        }
        
    }
}
