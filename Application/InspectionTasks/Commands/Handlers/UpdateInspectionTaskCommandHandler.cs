using Application.InspectionTasks.Commands.Requests;
using Application.InspectionTasks.Helpers;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Commands.Handlers
{
    public class UpdateInspectionTaskCommandHandler : IRequestHandler<UpdateInspectionTaskCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public UpdateInspectionTaskCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateInspectionTaskCommand request, CancellationToken cancellationToken)
        {
            var taskFromDB = await _unitOfWork.InspectionTaskRepository.GetAsync(request.Id, cancellationToken);
            if (taskFromDB == null)
                throw new Exception($"Nie można edytować Zadania: Nie istnieje Zadanie o Id: {request.Id}");
            if (taskFromDB.Status==InspectionTaskStatus.IN_PROGRESS)
                throw new Exception($"Nie można edytować Zadania: Zadanie zostało już rozpoczęte");
            await CheckIfUpdatedValuesAreAllowed(request, cancellationToken);

            taskFromDB.BuildingId = request.BuildingId;
            taskFromDB.TaskDelegatorId = request.TaskDelegatorId;
            taskFromDB.TaskPerformerId = request.TaskPerformerId;
            taskFromDB.Status = request.Status;
            if(request.DueStartDateTime!=null)
                taskFromDB.DueStartDateTime = request.DueStartDateTime;
            if(request.StartDateTime!=null)
                taskFromDB.StartDateTime=request.StartDateTime;
            if (request.EndDateTime != null)
            { 
                taskFromDB.EndDateTime = request.EndDateTime;
            }
            await _unitOfWork.InspectionTaskRepository.UpdateAsync(taskFromDB, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
        private async Task CheckIfUpdatedValuesAreAllowed(UpdateInspectionTaskCommand request, CancellationToken cancellationToken)
        {
            var building = await _unitOfWork.BuildingRepository.GetAsync(request.BuildingId, cancellationToken);
            if (building == null)
                throw new Exception($"Nie można edytować Zadania: podane Id Budynku nie istnieje");
            var delegator = await _unitOfWork.UsersRepository.GetByIdAsync(request.TaskDelegatorId, cancellationToken);
            if (delegator == null)
                throw new Exception($"Nie można edytować Zadania: Nie istnieje Zlecający Zadanie o podanym Id");
            var performer = await _unitOfWork.UsersRepository.GetByIdAsync(request.TaskPerformerId, cancellationToken);
            if (performer == null)
                throw new Exception($"Nie można edytować Zadania: Nie istnieje Wykonujący Zadanie o podanym Id");

            if (!InspectionTaskHelper.isStatusAllowed(request.Status))
                throw new Exception($"Nie można edytować Zadania: Niedozwolony status");
            
            if (request.EndDateTime != null && request.EndDateTime <= request.StartDateTime)
                throw new Exception($"Nie można edytować Zadania: Data zakończenia jest wcześniejsza od daty rozpoczęcia");
        }
    }
}
