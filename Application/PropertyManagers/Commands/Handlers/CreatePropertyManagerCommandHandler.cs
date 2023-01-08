
using Application.FullAddresses.HelperMethods;
using Application.PropertyManagers.Commands.Requests;
using Application.Roles.Commands.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
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
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IFullAddressRepository _fullAddressRepository;
        private readonly IBuildingAddressRepository _buildingAddressRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;

        public CreatePropertyManagerCommandHandler(IPropertyManagerRepository propertyManagerRepository,
            IFullAddressRepository fullAddressRepository,
            IBuildingAddressRepository buildingAddressRepository,
            IPropertyAddressRepository propertyAddressRepository)
        {
            _propertyManagerRepository = propertyManagerRepository;
            _fullAddressRepository = fullAddressRepository;
            _buildingAddressRepository = buildingAddressRepository;
            _propertyAddressRepository = propertyAddressRepository;
        }

        public async Task<Guid> Handle(CreatePropertyManagerCommand request, CancellationToken cancellationToken)
        {
            var faDTO = request.FullAddressDTO;

            var baFromDB = await _buildingAddressRepository.GetAsync(faDTO.BuildingAddressId, cancellationToken);
            if (baFromDB == null)
                throw new Exception($"W bazie danych nie ma adresu budynku o id: {faDTO.BuildingAddressId}");

            //FullAddressCRUDHelper helper = new FullAddressCRUDHelper(_fullAddressRepository, _propertyAddressRepository);
            //Guid fullAddressId = await helper.GetCreatedOrAlreadyExistingFullAddressId(request.FullAddressDTO, cancellationToken)
            //
            //;
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
                var propertyAddressId = await _propertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
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
            fullAddressId = await _fullAddressRepository.AddAsync(fullAddress, cancellationToken);

            PropertyManager propertyManager = new()
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                FullAddressId = fullAddressId,

            };
            return await _propertyManagerRepository.AddAsync(propertyManager, cancellationToken);
        }
    }
}
 
