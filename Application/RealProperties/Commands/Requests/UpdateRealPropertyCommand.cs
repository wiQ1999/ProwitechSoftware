using Application.FullAddresses.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Commands.Requests
{
    public record UpdateRealPropertyCommand : IRequest
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid BuildingId { get; set; }
        [Required]
        public PropertyAddressWithVenueNumberDTO PropertyAddressWithVenueNumberDTO { get; set; }
    }
}
