using Application.Buildings.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
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

        public CreateBuildingCommandHandler(IBuildingAddressRepository buildingAddressRepository, IPropertyManagerRepository propertyManagerRepository, IBuildingRepository buildingRepository)
        {
            _buildingAddressRepository = buildingAddressRepository;
            _propertyManagerRepository = propertyManagerRepository;
            _buildingRepository = buildingRepository;
        }

        public async Task<Guid> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
            var pmFromDB = await _propertyManagerRepository.GetAsync(request.PropertyManagerId, cancellationToken);
            if (pmFromDB == null)
                throw new Exception($"Brak w bazie danych Zarządcy Nieruchomości o Id: {request.PropertyManagerId}");
            var baFromDB = await _buildingAddressRepository.GetAsync(request.BuildingAddressId, cancellationToken);
            if (baFromDB== null)
                throw new Exception($"Brak w bazie danych Adresu Budynku o Id: {request.BuildingAddressId}");

            Building building = new Building()
            {
                BuildingAddressId = request.BuildingAddressId,
                PropertyManagerId = request.PropertyManagerId,
                Type=request.Type
            };
            return await _buildingRepository.AddAsync(building, cancellationToken);
        }
    }
}
