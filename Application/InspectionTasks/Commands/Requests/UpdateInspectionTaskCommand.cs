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
    public record UpdateInspectionTaskCommand: IRequest
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid TaskDelegatorId { get; set; }
        [Required]
        public Guid TaskPerformerId { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public Guid BuildingId { get; set; }
        public DateTime? DueStartDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
}
