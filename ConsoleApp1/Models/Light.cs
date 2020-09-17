using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHomeDAL
{
    public class Light 
    {
        
        public Color color { get; set; }

        public enum Color
        {
            Yellow,
            White,
            Red,
            Orange,
            Violet,
            Pink
        }

        public string name { get; set; }
        public int Id { get; set; }
        public bool isOn { get; set; }

        public Room location { get; set; }

    }
}
