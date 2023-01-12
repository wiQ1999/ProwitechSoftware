using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Commands.Requests
{
    public record CreateInspectionTaskCommand: IRequest<Guid>
    {
        [Required]
        public Guid TaskDelegatorId { get; set; }
        [Required]
        public Guid TaskPerformerId { get; set; }
        [Required]
        public Guid BuildingId { get; set; }
        [Required]
        public DateTime DueStartDateTime { get; set; }
    }
}
