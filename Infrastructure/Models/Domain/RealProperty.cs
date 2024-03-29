﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class RealProperty
    {
        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public Building Building { get; set; }
        public Guid? PropertyAddressId { get; set; }
        public PropertyAddress? PropertyAddress { get; set; }
    }
}
