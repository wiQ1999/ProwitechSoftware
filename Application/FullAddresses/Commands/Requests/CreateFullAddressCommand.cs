using Application.LocalInfos.Commands.Requests;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.Commands.Requests
{
    public record CreateFullAddressCommand:IRequest<Guid>
    {
        [Required]
        public Guid BuildingAddressId { get; set; }
        public CreateLocalInfoCommand? LocalInfo { get; set; }
    }
}
