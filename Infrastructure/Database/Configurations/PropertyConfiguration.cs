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
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder
                .HasOne(p => p.Building)
                .WithMany(b => b.Properties)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(p => p.PropertyAddress)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
