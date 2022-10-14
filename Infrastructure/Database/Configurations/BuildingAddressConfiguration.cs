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
    public class BuildingAddressConfiguration : IEntityTypeConfiguration<BuildingAddress>
    {
        public void Configure(EntityTypeBuilder<BuildingAddress> builder)
        {
           
        }
    }
}
