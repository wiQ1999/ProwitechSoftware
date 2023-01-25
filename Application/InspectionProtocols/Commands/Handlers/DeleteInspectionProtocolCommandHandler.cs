using Application.InspectionProtocols.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
            InspectionProtocol? protocolToDelete = await _unitOfWork.InspectionProtocolsRepository.GetAsync(request.Id, cancellationToken);
            if (protocolToDelete == null)
                throw new Exception($"Nie można usunąć Protokołu Inspekcji: Brak Protokołu o ID: {request.Id}");
            var resident = protocolToDelete.Resident;
            await _unitOfWork.InspectionProtocolsRepository.DeleteAsync(request.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            await _unitOfWork.ResidentsRepository.DeleteResidentIfNoProtocolsAreAssignedToThem(resident!, cancellationToken);

            
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
