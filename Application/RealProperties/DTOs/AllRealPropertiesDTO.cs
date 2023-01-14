using Application.Buildings.DTOs;
using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.DTOs
{
    public class AllRealPropertiesDTO
    {
        public Guid Id { get; set; }
        public AllBuildingsDTO BuildingDTO { get; set; }
        public PropertyAddress? PropertyAddress { get; set; }
    }
}
