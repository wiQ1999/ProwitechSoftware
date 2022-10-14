﻿using Application.BuildingAddresses.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Queries.Requests
{
    public record GetBuildingAddressesQuery : IRequest<IEnumerable<BuildingAddressDTO>>;

}
