using Application.Buildings.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Commands.Handlers
{
    public class DeleteBuildingCommandHandler : IRequestHandler<DeleteBuildingCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public DeleteBuildingCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteBuildingCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.BuildingRepository.DeleteAsync(request.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
