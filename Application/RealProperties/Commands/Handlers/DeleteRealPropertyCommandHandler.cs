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
            await _unitOfWork.RealPropertyRepository.DeleteAsync(request.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
