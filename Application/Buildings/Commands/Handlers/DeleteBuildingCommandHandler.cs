using Application.Buildings.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
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
        private readonly IBuildingRepository _buildingRepository;

        public DeleteBuildingCommandHandler(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }

        public async Task<Unit> Handle(DeleteBuildingCommand request, CancellationToken cancellationToken)
        {
            await _buildingRepository.DeleteAsync(request.Id, cancellationToken);
            return Unit.Value;
        }
    }
}
