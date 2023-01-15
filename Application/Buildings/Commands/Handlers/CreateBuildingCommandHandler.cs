using Application.Buildings.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
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
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public CreateBuildingCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
            if (request.PropertyManagerId != Guid.Empty)
            {
                var pmFromDB = await _unitOfWork.PropertyManagerRepository.GetAsync(request.PropertyManagerId, cancellationToken);
                if (pmFromDB == null)
                    throw new Exception($"Brak w bazie danych Zarządcy Nieruchomości o Id: {request.PropertyManagerId}");
            }
            
            var baFromDB = await _unitOfWork.BuildingAddressRepository.GetAsync(request.BuildingAddressId, cancellationToken);
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
            
            var buildingId= await _unitOfWork.BuildingRepository.AddAsync(building, request.BuildingAddressId, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            if(building.Type==BuildingType.JEDNOLOKALOWY.ToString())
            {
                PropertyAddress propertyAddress = new PropertyAddress();
                var propertyAddressId= await _unitOfWork.PropertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                RealProperty property = new RealProperty()
                {
                    BuildingId = buildingId,
                    PropertyAddressId = propertyAddressId,
                    PropertyAddress = propertyAddress
                };
                await _unitOfWork.RealPropertyRepository.AddAsync(property, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            return buildingId;
        }
    }
}
