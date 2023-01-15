using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Commands.Requests
{
    public record DeleteRealPropertyCommand : IRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
