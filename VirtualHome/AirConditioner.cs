using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class AirConditioner : Device
    {
        private string model;
        private double temperature;
        public AirConditioner(string name, string model) : base(name)
        {
            this.model = model;
            temperature = 23d;
        }
        public string GetModel()
        {
            return model;
        }

        public double GetTemperature()
        {
            return temperature;
        }
        public void SetTemperature(double temperature)
        {
            if (temperature > 18 && temperature < 26)
            {
                this.temperature = temperature;
            }
            else
            {
                Console.WriteLine("Invalid temp value.");
            }
        }

    }
}
