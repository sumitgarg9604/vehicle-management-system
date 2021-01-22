using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagementSystemAPI.Models;


namespace VehicleManagementSystemAPI.Models
{
    public class ApplicationDbContext:DbContext
    {
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Vehicles> Vehicles { get; set; }

        public DbSet<AdTypes> AdTypes { get; set; }

        public DbSet<BodyTypes> BodyTypes { get; set; }

        public DbSet<VehicleTypes> VehicleTypes { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>().ToTable("Cars");
         }

         public DbSet<VehicleManagementSystemAPI.Models.Cars> Cars { get; set; }
    }
}
