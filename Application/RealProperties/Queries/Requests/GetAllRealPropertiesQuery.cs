using Application.RealProperties.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Queries.Requests
{
    public record GetAllRealPropertiesQuery : IRequest<IEnumerable<AllRealPropertiesDTO>>
    {
    }
}
