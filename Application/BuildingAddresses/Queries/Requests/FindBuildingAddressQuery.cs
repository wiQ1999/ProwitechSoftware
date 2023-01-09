using Application.BuildingAddresses.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Queries.Requests
{
    public record FindBuildingAddressQuery : IRequest<BuildingAddressDTO>
    {
        [Required]
        public string CityName { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string BuildingNumber { get; set; }
    }
}
