using Application.InspectionTasks.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Commands.Handlers
{
    public class DeleteInspectionTaskCommandHandler : IRequestHandler<DeleteInspectionTaskCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public DeleteInspectionTaskCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteInspectionTaskCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.InspectionTaskRepository.DeleteAsync(request.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
