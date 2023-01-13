using Application.RealProperties.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
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

        public CreateRealPropertyCommandHandler(IRealPropertyRepository realPropertyRepository, IPropertyAddressRepository propertyAddressRepository)
        {
            _realPropertyRepository = realPropertyRepository;
            _propertyAddressRepository = propertyAddressRepository;
        }

        public async Task<Guid> Handle(CreateRealPropertyCommand request, CancellationToken cancellationToken)
        {
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
