using Application.RealProperties.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Commands.Handlers
{
    public class DeleteRealPropertyCommandHandler : IRequestHandler<DeleteRealPropertyCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public DeleteRealPropertyCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteRealPropertyCommand request, CancellationToken cancellationToken)
        {
            var thisPropertyProtocols = await _unitOfWork.InspectionProtocolsRepository.GetProtocolsOfParticularRealProperty(request.Id, cancellationToken);
            if (thisPropertyProtocols != null)
                throw new Exception($"Nie wolno usunąć Nieruchomości o Id: {request.Id}," +
                    $" ponieważ jest do niej przypisany przynajmniej jeden protokół");
            
            await _unitOfWork.RealPropertyRepository.DeleteAsync(request.Id , cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
