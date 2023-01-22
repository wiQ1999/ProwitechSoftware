using Application.InspectionProtocols.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Queries.Requests
{
    public record GetBuildingProtocolsQuery:IRequest<IEnumerable<AllInspectionProtocolsDTO>>
    {
        [Required]
        public Guid BuildingId { get; set; }
    }
}
