using Application.RealProperties.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Commands.Handlers
{
    public class CreateRealPropertyCommandHandler : IRequestHandler<CreateRealPropertyCommand, Guid>
    {
        private readonly IRealPropertyRepository _realPropertyRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;
        private readonly IBuildingRepository _buildingRepository;

        public CreateRealPropertyCommandHandler(IRealPropertyRepository realPropertyRepository, IPropertyAddressRepository propertyAddressRepository, IBuildingRepository buildingRepository)
        {
            _realPropertyRepository = realPropertyRepository;
            _propertyAddressRepository = propertyAddressRepository;
            _buildingRepository = buildingRepository;
        }

        public async Task<Guid> Handle(CreateRealPropertyCommand request, CancellationToken cancellationToken)
        {
            var building = await _buildingRepository.GetAsync(request.BuildingId, cancellationToken);
            if (building == null)
                throw new Exception($"Nie można utworzyć Nieruchomości: Brak w bazie danych Budynku o Id: {request.BuildingId}");

            PropertyAddress propertyAddress = new PropertyAddress()
            {
                VenueNumber = request.PropertyAddressWithVenueNumberDTO.VenueNumber,
                StaircaseNumber = request.PropertyAddressWithVenueNumberDTO.StaircaseNumber
            };
            var propertyAddressId = await _propertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
            RealProperty realProperty = new RealProperty()
            {
                BuildingId = request.BuildingId,
                PropertyAddressId = propertyAddressId,
                PropertyAddress=propertyAddress
            };
            return await _realPropertyRepository.AddAsync(realProperty, cancellationToken);
        }
        
        
    }
}
