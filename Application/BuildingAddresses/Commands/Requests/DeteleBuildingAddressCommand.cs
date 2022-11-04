using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Commands.Requests
{
    public record DeleteBuildingAddressCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
