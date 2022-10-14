using Application.BuildingAddresses.DTOs;
using Application.Responses.BuildingAddressController;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Commands.Requests
{
    public record CreateBuildingAddressCommand : IRequest<AddBuildingAddressResponse>
    {
        public AddBuildingAddressDTO AddressDTO;
        public bool Force;
    }
}
