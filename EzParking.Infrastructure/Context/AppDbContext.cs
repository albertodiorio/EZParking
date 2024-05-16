using EZParking.Common.Security.Users;
using EZParking.Common.Validations;
using EZParking.Domain.ParkingLots.Entities;
using EZParking.Infrastructure.Mappings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EZParking.Infrastructure.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ParkingLot> ParkingLots { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Ignore<Error>();
            builder.Ignore<ValidationResult>();
            builder.ApplyConfiguration(new ParkingLotMapping());
            builder.ApplyConfiguration(new AddressMapping());
        }
    }
}
