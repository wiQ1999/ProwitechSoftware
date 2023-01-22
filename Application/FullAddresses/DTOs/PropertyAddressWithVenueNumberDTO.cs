using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.DTOs
{
    public class PropertyAddressWithVenueNumberDTO
    {
        [Required]
        public string VenueNumber { get; set; }
        public string? StaircaseNumber { get; set; }
    }
}
