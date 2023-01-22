using Application.RealProperties.DTOs;
using Application.PropertyManagers.DTOs;
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
        public PropertyManagerDTO? PropertyManager { get; set; }

        public IEnumerable<RealPropertyInListDTO>? Properties { get; set; }

    }
}
