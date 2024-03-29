﻿using Application.BuildingAddresses.DTOs;
using Infrastructure.Responses.BuildingAddressController;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Commands.Requests
{
    public record CreateBuildingAddressCommand : IRequest<AddUpdateBuildingAddressReponse>
    {
        public AddBuildingAddressDTO AddressDTO;
        public bool ForceDespiteCoordIssue;
        public bool AddAddressWithoutCoordinates;
    }
}
