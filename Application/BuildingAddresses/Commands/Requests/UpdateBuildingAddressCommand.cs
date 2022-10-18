using Application.BuildingAddresses.DTOs;
using Infrastructure.Responses.BuildingAddressController;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Commands.Requests
{
    public record UpdateBuildingAddressCommand: IRequest<AddUpdateBuildingAddressReponse>
    {
        public Guid Id;
        public UpdateBuildingAddressDTO AddressDTO;
        public bool UpdateWithNotAccurateCoords;
        public bool UpdateWithoutCoords;
    }
}
