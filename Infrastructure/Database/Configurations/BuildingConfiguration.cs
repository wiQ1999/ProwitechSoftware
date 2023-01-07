using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Configurations
{
    public class BuildingConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.Property(b => b.Type).HasMaxLength(50).IsRequired();
            builder
                .HasOne(b => b.PropertyManager)
                .WithMany(pm => pm.Buildings)
                .HasForeignKey(b => b.PropertyManagerId)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasOne(b => b.BuildingAddress)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
