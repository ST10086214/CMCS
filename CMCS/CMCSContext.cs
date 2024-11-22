using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS.DataAccess
{
    public class CMCSContext : DbContext
    {
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<ClaimStatus> ClaimStatuses { get; set; }

        // Constructor to specify the connection string
        public CMCSContext(DbContextOptions<CMCSContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Put your actual connection string here
                optionsBuilder.UseSqlServer("YourConnectionStringHere");
            }
        }
    }
}
