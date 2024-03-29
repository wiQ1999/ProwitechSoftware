﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.DTOs
{
    public record UpdateFullAddressDTO
    {
        public Guid BuildingAddressId { get; set; }
        
        public PropertyAddressDTO? PropertyAddress { get; set; }
        
    }
}
