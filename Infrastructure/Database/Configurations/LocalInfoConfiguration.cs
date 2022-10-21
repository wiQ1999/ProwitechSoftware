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
    
    public class LocalInfoConfiguration : IEntityTypeConfiguration<LocalInfo>
    {
        public void Configure(EntityTypeBuilder<LocalInfo> builder)
        {
            //builder.HasOne(l=>l.BuildingAddress).WithMany().OnDelete(DeleteBehavior.)
        }
    }
}
