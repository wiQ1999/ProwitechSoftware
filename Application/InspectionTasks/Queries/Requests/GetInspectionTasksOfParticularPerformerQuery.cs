using Application.InspectionTasks.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Requests
{
    public record GetInspectionTasksOfParticularPerformerQuery:IRequest<IEnumerable<AllInspectionTasksDTO>>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
