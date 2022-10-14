using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class LocalInfo
    {
        public Guid Id { get; set; }
        public string LocalNumber { get; set; }
        public string? StaircaseNumber { get; set; }
    }
}
