using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class BuildingAddress
    {
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string CityName { get; set; }
        [MaxLength(100)]
        public string StreetName { get; set; }
        [MaxLength(10)]
        public string BuildingNumber { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        [MaxLength(100)]
        public string? CoordinateType { get; set; }
        [MaxLength(10)]
        public string? PostalCode { get; set; }

        public BuildingAddress DeepCopy()
        {
            BuildingAddress copy = new BuildingAddress(this.CityName, this.StreetName, this.BuildingNumber, this.PostalCode);
            return copy;
        }
        public BuildingAddress(string cityName, string streetName, string buildingNumber, string postalCode)
        {
            CityName = cityName;
            StreetName = streetName;
            BuildingNumber = buildingNumber;
            PostalCode = postalCode;
        }
        public BuildingAddress()
        {

        }
        public override bool Equals(object? obj)
        {
            return obj is BuildingAddress address &&
                   CityName.ToUpper() == address.CityName.ToUpper() &&
                   StreetName.ToUpper() == address.StreetName.ToUpper() &&
                   BuildingNumber == address.BuildingNumber;
        }
    }
}
