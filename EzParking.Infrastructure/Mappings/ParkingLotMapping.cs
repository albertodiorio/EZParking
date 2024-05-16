using EZParking.Domain.ParkingLots.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EZParking.Infrastructure.Mappings
{
    public class ParkingLotMapping : IEntityTypeConfiguration<ParkingLot>
    {
        public void Configure(EntityTypeBuilder<ParkingLot> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(500).IsRequired();
            builder.Property(p => p.FiscalCode).HasMaxLength(15).IsRequired();
            builder.Property(p => p.IsActive).HasDefaultValue(true);

            builder.HasMany(p => p.Addresses).WithOne(p => p.ParkingLot).HasForeignKey(p => p.Id);

            builder.ToTable("ParkingLot");
        }
    }
}
