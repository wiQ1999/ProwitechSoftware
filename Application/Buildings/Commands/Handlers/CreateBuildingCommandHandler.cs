using Application.Buildings.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Commands.Handlers
{
    public class CreateBuildingCommandHandler : IRequestHandler<CreateBuildingCommand, Guid>
    {
        private readonly IBuildingAddressRepository _buildingAddressRepository;
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IBuildingRepository _buildingRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;
        private readonly IPropertyRepository _propertyRepository;

        public CreateBuildingCommandHandler(IBuildingAddressRepository buildingAddressRepository, IPropertyManagerRepository propertyManagerRepository, IBuildingRepository buildingRepository, IPropertyAddressRepository propertyAddressRepository, IPropertyRepository propertyRepository)
        {
            _buildingAddressRepository = buildingAddressRepository;
            _propertyManagerRepository = propertyManagerRepository;
            _buildingRepository = buildingRepository;
            _propertyAddressRepository = propertyAddressRepository;
            _propertyRepository = propertyRepository;
        }

        public async Task<Guid> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
            if (request.PropertyManagerId != Guid.Empty)
            {
                var pmFromDB = await _propertyManagerRepository.GetAsync(request.PropertyManagerId, cancellationToken);
                if (pmFromDB == null)
                    throw new Exception($"Brak w bazie danych Zarządcy Nieruchomości o Id: {request.PropertyManagerId}");
            }
            
            var baFromDB = await _buildingAddressRepository.GetAsync(request.BuildingAddressId, cancellationToken);
            if (baFromDB== null)
                throw new Exception($"Brak w bazie danych Adresu Budynku o Id: {request.BuildingAddressId}");

            Building building;
            if(request.PropertyManagerId != Guid.Empty){
                building = new Building()
                {
                    BuildingAddressId = request.BuildingAddressId,
                    PropertyManagerId = request.PropertyManagerId,
                    Type = request.Type
                };
            }
            else
            {
                building = new Building()
                {
                    BuildingAddressId = request.BuildingAddressId,
                    Type = request.Type
                };
            }
            
            var buildingId= await _buildingRepository.AddAsync(building, cancellationToken);
            if(building.Type==BuildingType.JEDNOLOKALOWY.ToString())
            {
                PropertyAddress propertyAddress = new PropertyAddress();
                var propertyAddressId= await _propertyAddressRepository.AddAsync(propertyAddress, cancellationToken);

                Property property = new Property()
                {
                    BuildingId = buildingId,
                    PropertyAddressId = propertyAddressId
                };
                await _propertyRepository.AddAsync(property, cancellationToken);

            }
            return buildingId;
        }
    }
}
