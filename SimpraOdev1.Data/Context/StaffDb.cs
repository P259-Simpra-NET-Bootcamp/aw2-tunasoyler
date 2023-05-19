using Microsoft.EntityFrameworkCore;
using SimpraOdev1.Core.Entities;
using SimpraOdev1.Data.Configurations;

namespace SimpraOdev1.Data.Context
{
    public class StaffDb : DbContext
    {
        public DbSet<Staff> Staff { get; set; }

        public StaffDb(DbContextOptions<StaffDb> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StaffConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BVE8G4S;Database=StaffDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
