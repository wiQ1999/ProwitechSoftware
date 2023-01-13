using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Commands.Requests
{
    public record DeleteInspectionTaskCommand:IRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
