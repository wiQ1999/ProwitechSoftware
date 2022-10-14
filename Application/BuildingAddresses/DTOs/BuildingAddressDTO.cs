using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.DTOs
{
    public class BuildingAddressDTO
    {
        public Guid Id { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public string BuildingNumber { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string CoordinateType { get; set; }
        public string PostalCode { get; set; }
    }
}
