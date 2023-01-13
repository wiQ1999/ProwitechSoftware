using Application.InspectionTasks.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
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
        private readonly IInspectionTaskRepository _inspectionTaskRepository;

        public DeleteInspectionTaskCommandHandler(IInspectionTaskRepository inspectionTaskRepository)
        {
            _inspectionTaskRepository = inspectionTaskRepository;
        }

        public async Task<Unit> Handle(DeleteInspectionTaskCommand request, CancellationToken cancellationToken)
        {
            await _inspectionTaskRepository.DeleteAsync(request.Id, cancellationToken);
            return Unit.Value;
        }
    }
}
