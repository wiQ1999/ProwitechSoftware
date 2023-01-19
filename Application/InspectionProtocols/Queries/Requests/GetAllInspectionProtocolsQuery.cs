using Application.InspectionProtocols.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Queries.Requests
{
    public record GetAllInspectionProtocolsQuery: IRequest<IEnumerable<AllInspectionProtocolsDTO>>
    {
    }
}
