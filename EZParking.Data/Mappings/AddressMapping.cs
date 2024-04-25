using EZParking.Domain.ParkingLots.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Street).HasMaxLength(200).IsRequired();
            builder.Property(a => a.City).HasMaxLength(100).IsRequired();
            builder.Property(a => a.State).HasMaxLength(2).IsRequired();

        }
    }
}
