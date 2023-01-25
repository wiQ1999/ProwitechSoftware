using Application.InspectionTasks.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
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
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public CreateInspectionTaskCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateInspectionTaskCommand request, CancellationToken cancellationToken)
        {
            var iT = new InspectionTask()
            {
                TaskDelegatorId = request.TaskDelegatorId,
                TaskPerformerId = request.TaskPerformerId,
                Status=InspectionTaskStatus.NEW,
                BuildingId = request.BuildingId,
                DueStartDateTime = request.DueStartDateTime
            };
            var iTAdded= await _unitOfWork.InspectionTaskRepository.AddAsync(iT, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return iTAdded;
        }
    }
}
