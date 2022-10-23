using Application.FullAddresses.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.Commands.Requests
{
    public record UpdatePropertyManagerCommand:IRequest
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public UpdateFullAddressDTO? UpdateFullAddressDTO { get; set; }
    }
}
