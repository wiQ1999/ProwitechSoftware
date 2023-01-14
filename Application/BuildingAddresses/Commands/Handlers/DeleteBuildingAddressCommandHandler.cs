using Application.BuildingAddresses.Commands.Requests;
using Application.PropertyManagers.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Commands.Handlers
{
    public class DeleteBuildingAddressCommandHandler : IRequestHandler<DeleteBuildingAddressCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public DeleteBuildingAddressCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteBuildingAddressCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.BuildingAddressRepository.DeleteAsync(request.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
