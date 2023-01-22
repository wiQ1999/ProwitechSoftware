using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Commands.Requests
{
    public record DeleteInspectionProtocolCommand:IRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
