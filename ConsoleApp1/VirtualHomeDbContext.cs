using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
namespace VirtualHomeDAL
{
   public class VirtualHomeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlServer("Server=localhost;Database=VirtualHomeDB;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer("Server=XE2350558W1;Database=VirtualHomeDB;Trusted_Connection=True;");
        }

        public DbSet<TV> TVs { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<DoorLock> DoorLocks { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<AirConditioner> AirConditioners { get; set; }

        public DbSet<Light> Lights { get; set; }

    }
}
