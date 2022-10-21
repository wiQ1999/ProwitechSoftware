using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class PropertyManager
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Guid FullAddressId { get; set; }
        public FullAddress? FullAddress { get; set; }
        public ICollection<Building> Buildings { get; set; }
    }
}
