using Application.BuildingAddresses.Commands.Requests;
using Infrastructure.Responses.BuildingAddressController;
using AutoMapper;
using Infrastructure.GoogleAPI;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Responses;
using Infrastructure.Interfaces.UnitOfWork;

namespace Application.BuildingAddresses.Commands.Handlers
{
    public class CreateBuildingAddressCommandHandler : IRequestHandler<CreateBuildingAddressCommand, AddUpdateBuildingAddressReponse>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public CreateBuildingAddressCommandHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<AddUpdateBuildingAddressReponse> Handle(CreateBuildingAddressCommand request, CancellationToken cancellationToken)
        {
            var address = mapper.Map<BuildingAddress>(request.AddressDTO);
            GoogleGeocodingClient client = new GoogleGeocodingClient(address);
            AddUpdateBuildingAddressReponse addBuildingAddressResponse = await client.SetCoordinatesAndPostalCode(request.ForceDespiteCoordIssue);
            if (addBuildingAddressResponse.WebApiStatus == ProwitechWebAPIStatus.ADDED_TO_DB.ToString()
                || addBuildingAddressResponse.WebApiStatus==ProwitechWebAPIStatus.ADDED_DESPITE_COORDINATE_ISSUE.ToString())
            {
                addBuildingAddressResponse.AddedBuildingAddress
                    = await _unitOfWork.BuildingAddressRepository.AddAsync(addBuildingAddressResponse.AddedBuildingAddress, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            else if(addBuildingAddressResponse.WebApiStatus==ProwitechWebAPIStatus.NOT_ADDED_COORDINATES_TYPE_ISSUE.ToString()
                && request.AddAddressWithoutCoordinates)
            {
                addBuildingAddressResponse.WebApiStatus = ProwitechWebAPIStatus.ADDED_TO_DB_WITHOUT_COORDINATES.ToString();
                addBuildingAddressResponse.AddedBuildingAddress.Longitude = null;
                addBuildingAddressResponse.AddedBuildingAddress.Latitude = null;
                addBuildingAddressResponse.AddedBuildingAddress.CoordinateType = null;
                //addBuildingAddressResponse.AddedBuildingAddress.PostalCode = null;
                addBuildingAddressResponse.AddedBuildingAddress
                    = await _unitOfWork.BuildingAddressRepository.AddAsync(addBuildingAddressResponse.AddedBuildingAddress, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            return addBuildingAddressResponse;
        }
    }
}
