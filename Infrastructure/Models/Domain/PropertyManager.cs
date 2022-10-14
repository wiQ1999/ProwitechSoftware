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
        public Guid ContactInfoId { get; set; }
        public ContactInfo Contact { get; set; }
        public ICollection<Building> Buildings { get; set; }
    }
}
