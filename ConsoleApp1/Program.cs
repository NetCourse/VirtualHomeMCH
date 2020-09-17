using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualHomeDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            var virtualHomeDbContext = new VirtualHomeDbContext();
            var query = virtualHomeDbContext.Lights.Where(x =>x.name == "small light");

            Console.WriteLine("Query result.");
            foreach (var x in query)
            {
                Console.WriteLine(x.name);
            }
        }

    }
}
