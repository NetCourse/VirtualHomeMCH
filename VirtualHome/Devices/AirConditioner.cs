using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class AirConditioner : Device
    {
        public string model { get; set;}
        private double temperature { get; set; }
        public AirConditioner(string name, string model) : base(name)
        {
            this.model = model;
            temperature = 23d;
        }
 

    }
}
