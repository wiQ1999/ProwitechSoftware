using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class Local
    {
        public Guid Id { get; set; }
        public Guid LocalInfoId { get; set; }
        public LocalInfo LocalInfo { get; set; }

        public Guid BuildingId { get; set; }
        public Building Building { get; set; }
        public ICollection<Resident> Residents { get; set; }
    }
}
