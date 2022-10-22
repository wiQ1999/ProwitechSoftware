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
    public class PropertyManagerConfiguration : IEntityTypeConfiguration<PropertyManager>
    {
        public void Configure(EntityTypeBuilder<PropertyManager> builder)
        {
            //builder.HasOne(p => p.FullAddress).WithMany().OnDelete(DeleteBehavior.SetNull);
        }
    }
}
