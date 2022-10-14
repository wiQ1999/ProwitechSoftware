using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Domain
{
    public class Building
    {
        public Guid Id { get; set; }
        public Guid BuildingAddressId { get; set; }
        public BuildingAddress BuildingAddress { get; set; }

        public string Type { get; set; }


        //Navigate Property
        public ICollection<Local>? Locals { get; set; }

        public Guid? PropertyManagerId { get; set; }
        public PropertyManager? PropertyManager { get; set; }


    }
}
