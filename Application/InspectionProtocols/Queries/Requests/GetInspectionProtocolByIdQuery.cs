using Application.InspectionProtocols.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Queries.Requests
{
    public record GetInspectionProtocolByIdQuery :IRequest<InspectionProtocolByIdDTO>
    {

        [Required]
        public Guid Id { get; set; }
    }
}
