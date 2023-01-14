
using Application.FullAddresses.HelperMethods;
using Application.PropertyManagers.Commands.Requests;
using Application.Roles.Commands.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.Commands.Handlers
{
    public class CreatePropertyManagerCommandHandler : IRequestHandler<CreatePropertyManagerCommand, Guid>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public CreatePropertyManagerCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreatePropertyManagerCommand request, CancellationToken cancellationToken)
        {
            var faDTO = request.FullAddressDTO;

            var baFromDB = await _unitOfWork.BuildingAddressRepository.GetAsync(faDTO.BuildingAddressId, cancellationToken);
            if (baFromDB == null)
                throw new Exception($"W bazie danych nie ma adresu budynku o id: {faDTO.BuildingAddressId}");

            var fullAddressDTO = request.FullAddressDTO;
            FullAddress fullAddress;
            Guid fullAddressId;
            if (fullAddressDTO.PropertyAddressDTO != null)
            {
                var propertyAddress = new PropertyAddress()
                {
                    VenueNumber = fullAddressDTO.PropertyAddressDTO.VenueNumber,
                    StaircaseNumber = fullAddressDTO.PropertyAddressDTO.StaircaseNumber
                };
                var propertyAddressId = await _unitOfWork.PropertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
                fullAddress = new FullAddress()
                {
                    BuildingAddressId = fullAddressDTO.BuildingAddressId,
                    PropertyAddressId = propertyAddressId
                };
            }
            else
            {
                fullAddress = new FullAddress()
                {
                    BuildingAddressId = fullAddressDTO.BuildingAddressId
                };
            }
            fullAddressId = await _unitOfWork.FullAddressRepository.AddAsync(fullAddress, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            PropertyManager propertyManager = new()
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                FullAddressId = fullAddressId,

            };
            var newPropMan= await _unitOfWork.PropertyManagerRepository.AddAsync(propertyManager, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return newPropMan;
        }
    }
}
 
