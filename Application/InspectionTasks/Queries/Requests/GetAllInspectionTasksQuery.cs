using Application.InspectionTasks.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Requests
{
    public record GetAllInspectionTasksQuery : IRequest<IEnumerable<AllInspectionTasksDTO>>;
    
}
