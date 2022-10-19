using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.DTOs
{
    public class BuildingByIdDTO
    {
        public Guid Id { get; set; }
        public BuildingAddress BuildingAddress { get; set; }

        public string Type { get; set; }

        //Navigate Property
        public ICollection<Local>? Locals { get; set; }

        public PropertyManager? PropertyManager { get; set; }

    }
}
