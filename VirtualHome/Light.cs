using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class Light : Device
    {
        
        private Color color;

        public enum Color
        {
            Yellow,
            White,
            Red,
            Orange,
            Violet,
            Pink
        }

        public Light(Color color, string name): base(name)
        {
            this.color = color;
        }
    }
}
