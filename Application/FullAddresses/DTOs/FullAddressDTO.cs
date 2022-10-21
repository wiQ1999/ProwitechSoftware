using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.DTOs
{
    public record FullAddressDTO
    {
        public Guid BuildingAddressId { get; set; }
        public LocalInfo? LocalInfo { get; set; }
    }
}
