using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.DTOs
{
    public record PropertyAddressDTO
    {
        public string? VenueNumber { get; set; }
        public string? StaircaseNumber { get; set; }
    }
}
