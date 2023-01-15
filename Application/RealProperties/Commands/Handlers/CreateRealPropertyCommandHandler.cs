using Application.Properties.Helpers;
using Application.RealProperties.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
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
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public CreateRealPropertyCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateRealPropertyCommand request, CancellationToken cancellationToken)
        {
            var building = await _unitOfWork.BuildingRepository.GetAsync(request.BuildingId, cancellationToken);
            if (building == null)
                throw new Exception($"Nie można utworzyć Nieruchomości: Brak w bazie danych Budynku o Id: {request.BuildingId}");

            PropertyAddress propertyAddress = new PropertyAddress()
            {
                VenueNumber = request.PropertyAddressWithVenueNumberDTO.VenueNumber,
                StaircaseNumber = request.PropertyAddressWithVenueNumberDTO.StaircaseNumber
            };
            var propertyAddressId = await _unitOfWork.PropertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            RealProperty realProperty = new RealProperty()
            {
                BuildingId = request.BuildingId,
                PropertyAddressId = propertyAddressId,
                PropertyAddress=propertyAddress
            };
            bool creationMode = true;
            RealPropertyHelper propertyHelper = new RealPropertyHelper(_unitOfWork);
            await propertyHelper.CheckIfRealPropertyAlreadyExists(realProperty, creationMode, cancellationToken);
            
            var newRealProp= await _unitOfWork.RealPropertyRepository.AddAsync(realProperty, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return newRealProp;
        }
        
        
    }
}
