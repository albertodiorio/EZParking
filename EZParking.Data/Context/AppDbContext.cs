using EZParking.Data.Mappings;
using EZParking.Domain.ParkingLots.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Data.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<ParkingLot> ParkingLots { get; set; }
        public DbSet<Address> Addresses { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ParkingLotMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
        }
    }
}
