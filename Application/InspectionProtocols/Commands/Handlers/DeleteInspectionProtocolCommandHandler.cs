using Application.InspectionProtocols.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Commands.Handlers
{
    public class DeleteInspectionProtocolCommandHandler : IRequestHandler<DeleteInspectionProtocolCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public DeleteInspectionProtocolCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteInspectionProtocolCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.InspectionProtocolsRepository.DeleteAsync(request.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
