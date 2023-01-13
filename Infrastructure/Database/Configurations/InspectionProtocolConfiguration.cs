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
    public class InspectionProtocolConfiguration : IEntityTypeConfiguration<InspectionProtocol>
    {
        public void Configure(EntityTypeBuilder<InspectionProtocol> builder)
        {
            builder
                .HasOne(ip => ip.InspectionTask)
                .WithMany(it => it.InspectionProtocols)
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasOne(ip => ip.InspectedProperty)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(ip => ip.Resident)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
