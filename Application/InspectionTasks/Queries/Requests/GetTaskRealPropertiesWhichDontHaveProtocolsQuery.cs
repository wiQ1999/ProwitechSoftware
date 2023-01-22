using Application.InspectionProtocols.DTOs;
using Application.RealProperties.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Requests
{
    public record GetTaskRealPropertiesWhichDontHaveProtocolsQuery:IRequest<IEnumerable<AllRealPropertiesDTO>>
    {
        [Required]
        public Guid TaskId { get; set; }
    }
}
