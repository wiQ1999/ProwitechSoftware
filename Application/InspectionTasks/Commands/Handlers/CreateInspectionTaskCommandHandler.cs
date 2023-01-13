using Application.InspectionTasks.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Commands.Handlers
{
    public class CreateInspectionTaskCommandHandler : IRequestHandler<CreateInspectionTaskCommand, Guid>
    {
        private readonly IInspectionTaskRepository _inspectionTaskRepository;

        public CreateInspectionTaskCommandHandler(IInspectionTaskRepository inspectionTaskRepository)
        {
            _inspectionTaskRepository = inspectionTaskRepository;
        }

        public async Task<Guid> Handle(CreateInspectionTaskCommand request, CancellationToken cancellationToken)
        {
            var iT = new InspectionTask()
            {
                TaskDelegatorId = request.TaskDelegatorId,
                TaskPerformerId = request.TaskPerformerId,
                Status=InspectionTaskStatus.NEW.ToString(),
                BuildingId = request.BuildingId,
                DueStartDateTime = request.DueStartDateTime
            };
            return await _inspectionTaskRepository.AddAsync(iT, cancellationToken);
        }
    }
}
