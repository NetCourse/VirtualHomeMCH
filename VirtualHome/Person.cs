using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHome
{
    class Person
    {
        private string name;
        private Access access;

        public Person(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public Access GetAccess()
        {
            return access;
        }
        public void SetAccess(Access access)
        {
            this.access = access;
        }
        
    }
}
