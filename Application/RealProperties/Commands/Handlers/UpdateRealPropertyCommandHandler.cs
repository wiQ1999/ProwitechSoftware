using Application.RealProperties.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Commands.Handlers
{
    public class UpdateRealPropertyCommandHandler : IRequestHandler<UpdateRealPropertyCommand>
    {
        private readonly IRealPropertyRepository _realPropertyRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;
        private readonly IBuildingRepository _buildingRepository;

        public UpdateRealPropertyCommandHandler(IRealPropertyRepository realPropertyRepository, IPropertyAddressRepository propertyAddressRepository, IBuildingRepository buildingRepository)
        {
            _realPropertyRepository = realPropertyRepository;
            _propertyAddressRepository = propertyAddressRepository;
            _buildingRepository = buildingRepository;
        }

        public async Task<Unit> Handle(UpdateRealPropertyCommand request, CancellationToken cancellationToken)
        {
            var realProperty = await _realPropertyRepository.GetAsync(request.Id, cancellationToken);
            if (realProperty == null)
                throw new Exception($"Nie można edytować Nieruchomości: Brak w bazie danych Nieruchomości o Id: {request.Id}");

            var building = await _buildingRepository.GetAsync(request.BuildingId, cancellationToken);
            if (building == null)
                throw new Exception($"Nie można utworzyć Nieruchomości: Brak w bazie danych Budynku o Id: {request.BuildingId}");

            realProperty.BuildingId = building.Id;
            realProperty.PropertyAddress.VenueNumber = request.PropertyAddressWithVenueNumberDTO.VenueNumber;
            realProperty.PropertyAddress.StaircaseNumber = request.PropertyAddressWithVenueNumberDTO.StaircaseNumber;

            await _realPropertyRepository.UpdateAsync(realProperty, cancellationToken);

            return Unit.Value;
        }
    }
}
