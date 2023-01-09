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
    public class InspectionTaskConfiguration : IEntityTypeConfiguration<InspectionTask>
    {
        public void Configure(EntityTypeBuilder<InspectionTask> builder)
        {
            builder
                .HasOne(it => it.Building)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasOne(it => it.TaskDelegator)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
