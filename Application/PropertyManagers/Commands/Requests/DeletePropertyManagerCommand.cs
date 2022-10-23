using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.Commands.Requests
{
    public record DeletePropertyManagerCommand:IRequest
    {
        public Guid Id { get; set; }
    }
}
