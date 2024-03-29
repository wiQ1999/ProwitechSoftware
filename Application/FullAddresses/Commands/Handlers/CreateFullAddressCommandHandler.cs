﻿using Application.FullAddresses.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
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
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public CreateFullAddressCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateFullAddressCommand request, CancellationToken cancellationToken)
        {
            FullAddress fullAddress;


            if (request.PropertyAddressDTO != null
                && (request.PropertyAddressDTO.VenueNumber != null || request.PropertyAddressDTO.StaircaseNumber != null))
            {
                PropertyAddress propertyAddress = new PropertyAddress()
                {
                    VenueNumber = request.PropertyAddressDTO.VenueNumber,
                    StaircaseNumber = request.PropertyAddressDTO.StaircaseNumber
                };
                var propertyAddressId = await _unitOfWork.PropertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
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

            var newFullAddress = await _unitOfWork.FullAddressRepository.AddAsync(fullAddress, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return newFullAddress;
        }
    }
}
