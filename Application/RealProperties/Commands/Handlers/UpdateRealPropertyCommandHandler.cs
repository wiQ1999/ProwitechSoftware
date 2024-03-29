﻿using Application.RealProperties.Commands.Requests;
using Application.RealProperties.Helpers;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Commands.Handlers
{
    public class UpdateRealPropertyCommandHandler : IRequestHandler<UpdateRealPropertyCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public UpdateRealPropertyCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateRealPropertyCommand request, CancellationToken cancellationToken)
        {
            var realProperty = await _unitOfWork.RealPropertyRepository.GetAsync(request.Id, cancellationToken);
            if (realProperty == null)
                throw new Exception($"Nie można edytować Nieruchomości: Brak w bazie danych Nieruchomości o Id: {request.Id}");

            var building = await _unitOfWork.BuildingRepository.GetAsync(request.BuildingId, cancellationToken);
            if (building == null)
                throw new Exception($"Nie można utworzyć Nieruchomości: Brak w bazie danych Budynku o Id: {request.BuildingId}");

            //var propertyAfterUpdate = new RealProperty()
            //{
            //    Id=request.Id,
            //    BuildingId = request.BuildingId,
            //    PropertyAddress = new PropertyAddress()
            //    {
            //        VenueNumber = request.PropertyAddressWithVenueNumberDTO.VenueNumber,
            //        StaircaseNumber = request.PropertyAddressWithVenueNumberDTO.StaircaseNumber,
            //    },
            //    PropertyAddressId=realProperty.PropertyAddressId
            //};

            realProperty.BuildingId = request.BuildingId;
            realProperty.PropertyAddress!.VenueNumber = request.PropertyAddressWithVenueNumberDTO.VenueNumber;
            realProperty.PropertyAddress.StaircaseNumber = request.PropertyAddressWithVenueNumberDTO.StaircaseNumber;

            bool creationMode = false;
            RealPropertyHelper propertyHelper = new RealPropertyHelper(_unitOfWork);
            await propertyHelper.CheckIfRealPropertyAlreadyExists(realProperty, creationMode, cancellationToken);

            //realProperty.BuildingId = building.Id;
            //realProperty.PropertyAddress!.VenueNumber = request.PropertyAddressWithVenueNumberDTO.VenueNumber;
            //realProperty.PropertyAddress.StaircaseNumber = request.PropertyAddressWithVenueNumberDTO.StaircaseNumber;

            await _unitOfWork.RealPropertyRepository.UpdateAsync(realProperty, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
