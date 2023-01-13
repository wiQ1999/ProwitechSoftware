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
        public Guid? PropertyAddressId { get; set; }
        public PropertyAddress? PropertyAddress { get; set; }

    }
}
