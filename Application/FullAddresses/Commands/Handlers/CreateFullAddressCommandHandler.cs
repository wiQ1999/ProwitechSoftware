using Application.FullAddresses.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.Commands.Handlers
{
    public class CreateFullAddressCommandHandler : IRequestHandler<CreateFullAddressCommand, Guid>
    {
        private readonly IFullAddressRepository _fullAddressRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;

        public CreateFullAddressCommandHandler(IFullAddressRepository fullAddressRepository, IPropertyAddressRepository propertyAddressRepository)
        {
            _fullAddressRepository = fullAddressRepository;
            _propertyAddressRepository = propertyAddressRepository;
        }

        public async Task<Guid> Handle(CreateFullAddressCommand request, CancellationToken cancellationToken)
        {
            FullAddress fullAddress;


            if (request.PropertyAddressDTO != null)
            {
                PropertyAddress propertyAddress = new PropertyAddress()
                {
                    VenueNumber = request.PropertyAddressDTO.VenueNumber,
                    StaircaseNumber = request.PropertyAddressDTO.StaircaseNumber
                };
                var propertyAddressId=await _propertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
                fullAddress = new FullAddress()
                {
                    BuildingAddressId = request.BuildingAddressId,
                    PropertyAddressId = propertyAddressId
                };
            }
            else
            {
                fullAddress = new FullAddress()
                {
                    BuildingAddressId = request.BuildingAddressId,
                };
            }

            return await _fullAddressRepository.AddAsync(fullAddress, cancellationToken);
        }
    }
}
