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
    public record GetBiggestProtocolNumberQuery : IRequest<BiggestNumberDTO>
    {
        [Required]
        public string DateTimeStr { get; set; }
    }
}
