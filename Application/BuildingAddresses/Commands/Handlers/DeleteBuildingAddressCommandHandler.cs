using Application.BuildingAddresses.Commands.Requests;
using Application.PropertyManagers.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
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
        private readonly IBuildingAddressRepository _buildingAddressRepository;

        public DeleteBuildingAddressCommandHandler(IBuildingAddressRepository buildingAddressRepository)
        {
            _buildingAddressRepository = buildingAddressRepository;
        }

        public async Task<Unit> Handle(DeleteBuildingAddressCommand request, CancellationToken cancellationToken)
        {
            await _buildingAddressRepository.DeleteAsync(request.Id, cancellationToken);
            return Unit.Value;
        }
    }
}
