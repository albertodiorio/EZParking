using EZParking.Infrastructure.Mappings;
using EZParking.Domain.ParkingLots.Entities;
using Microsoft.EntityFrameworkCore;
using EZParking.Common.Validations;

namespace EZParking.Infrastructure.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<ParkingLot> ParkingLots { get; set; }
        public DbSet<Address> Addresses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<Error>();
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.ApplyConfiguration(new ParkingLotMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
        }
    }
}
