using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class ContactInfo
    {
        public Guid Id { get; set; }
        public Guid FullAddressId { get; set; }
        public FullAddress FullAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
