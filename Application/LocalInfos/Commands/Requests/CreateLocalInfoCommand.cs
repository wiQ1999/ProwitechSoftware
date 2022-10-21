using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LocalInfos.Commands.Requests
{
    public record CreateLocalInfoCommand : IRequest<Guid>
    {
        public Guid? Id { get; set; }
        [Required]
        public string LocalNumber { get; set; }
        public string? StaircaseNumber { get; set; }
    }
}
