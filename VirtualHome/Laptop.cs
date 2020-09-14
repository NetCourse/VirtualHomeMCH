using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class Laptop : Device
    {
        private string make;
        private string model;
        public Laptop(string name, string make, string model) : base(name)
        {
            this.make = make;
            this.model = model;
        }

        public string GetMake()
        {
            return make;
        }
        public string getModel()
        {
            return model;
        }
      
    }
}
