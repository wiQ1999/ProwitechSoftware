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
    public class UpdateBuildingCommandHandler : IRequestHandler<UpdateBuildingCommand>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly IPropertyManagerRepository _propertyManagerRepository;

        public UpdateBuildingCommandHandler(IBuildingRepository buildingRepository, IPropertyManagerRepository propertyManagerRepository)
        {
            _buildingRepository = buildingRepository;
            _propertyManagerRepository = propertyManagerRepository;
        }

        public async Task<Unit> Handle(UpdateBuildingCommand request, CancellationToken cancellationToken)
        {
            
                
            var bFromDB = await _buildingRepository.GetAsync(request.Id, cancellationToken);
            if (bFromDB == null)
                throw new Exception($"Brak w bazie danych budynku o Id: {request.Id}");
            if (request.PropertyManagerId != Guid.Empty)
            {
                var pmFromDB = await _propertyManagerRepository.GetAsync(request.PropertyManagerId, cancellationToken);
                if (pmFromDB == null)
                    throw new Exception($"Brak w bazie danych Zarządcy Nieruchomości o Id: {request.PropertyManagerId}");
                bFromDB.PropertyManagerId = request.PropertyManagerId;
            }
            bFromDB.Type = request.Type;
            await _buildingRepository.UpdateBuildingAsync(bFromDB, cancellationToken);
            return Unit.Value;

        }
    }
}
