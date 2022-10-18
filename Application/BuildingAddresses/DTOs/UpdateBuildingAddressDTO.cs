using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.DTOs
{
    public record UpdateBuildingAddressDTO
    {
        [Required]
        public string CityName { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string BuildingNumber { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
    }
}
