using Application.InspectionTasks.Commands.Requests;
using Application.InspectionTasks.Helpers;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Commands.Handlers
{
    public class ChangeTaskStatusCommandHandler : IRequestHandler<ChangeTaskStatusCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public ChangeTaskStatusCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(ChangeTaskStatusCommand request, CancellationToken cancellationToken)
        {
            var taskFromDB = await _unitOfWork.InspectionTaskRepository.GetAsync(request.Id, cancellationToken);
            if (taskFromDB == null)
                throw new Exception($"Nie można edytować Zadania: Nie istnieje Zadanie o Id: {request.Id}");
            if (!InspectionTaskHelper.isStatusAllowed(request.Status))
                throw new Exception($"Nie można edytować Zadania: Niedozwolony status");
           
            taskFromDB.Status = request.Status;

            if (request.StartDateTime != null) taskFromDB.StartDateTime = request.StartDateTime;
            if (request.EndDateTime != null) taskFromDB.EndDateTime = request.EndDateTime;

            await _unitOfWork.InspectionTaskRepository.UpdateAsync(taskFromDB, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
