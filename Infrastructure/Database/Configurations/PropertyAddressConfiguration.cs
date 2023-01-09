using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Configurations
{
    internal class PropertyAddressConfiguration : IEntityTypeConfiguration<PropertyAddress>
    {
        public void Configure(EntityTypeBuilder<PropertyAddress> builder)
        {
            //builder
            //   .HasOne(ba => ba.FullAddress)
            //   .WithOne(fa => fa.PropertyAddress)
            //   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
