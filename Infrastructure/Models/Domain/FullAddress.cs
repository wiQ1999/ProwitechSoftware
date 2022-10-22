using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class FullAddress
    {
        public Guid Id { get; set; }
        public Guid BuildingAddressId { get; set; }
        public BuildingAddress BuildingAddress { get; set; }
        public string? LocalNumber { get; set; }
        public string? StaircaseNumber { get; set; }
        public override bool Equals(object? obj)
        {
            return obj is FullAddress address &&
                   EqualityComparer<BuildingAddress>.Default.Equals(BuildingAddress, address.BuildingAddress) &&
                   LocalNumber == address.LocalNumber;
        }

        public override string? ToString()
        {
            if (LocalNumber != null)
                return BuildingAddress.StreetName + BuildingAddress.BuildingNumber + LocalNumber + BuildingAddress.CityName;
            else
                return BuildingAddress.StreetName + BuildingAddress.BuildingNumber + BuildingAddress.CityName;
        }
    }
}
