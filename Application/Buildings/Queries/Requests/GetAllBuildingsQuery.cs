using Application.BuildingAddresses.DTOs;
using Application.Buildings.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Queries.Requests
{
    public record GetAllBuildingsQuery : IRequest<IEnumerable<AllBuildingsDTO>>;
}
