using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Commands.Requests
{
    public record UpdatePostalCodeCommand:IRequest
    {
        public Guid Id { get; set; }
        
        public string PostalCode { get; set; }
    }
}
