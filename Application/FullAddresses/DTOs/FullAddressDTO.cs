﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.DTOs;

public record FullAddressDTO
{
    [Required]
    public Guid BuildingAddressId { get; set; }
    public PropertyAddressDTO? PropertyAddressDTO { get; set; }
}
