using Application.FullAddresses.DTOs;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Commands.Requests
{
    public record CreateRealPropertyCommand: IRequest<Guid>
    {
        [Required]
        public Guid BuildingId { get; set; }
        [Required]
        public PropertyAddressWithVenueNumberDTO PropertyAddressWithVenueNumberDTO { get; set; }
    }
}
