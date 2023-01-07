﻿using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Configurations
{
    public class FullAddressConfiguration: IEntityTypeConfiguration<FullAddress>
    {
        public void Configure(EntityTypeBuilder<FullAddress> builder)
        {
            builder
                .HasOne(fa => fa.BuildingAddress)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(fa => fa.PropertyAddress)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
    
}
