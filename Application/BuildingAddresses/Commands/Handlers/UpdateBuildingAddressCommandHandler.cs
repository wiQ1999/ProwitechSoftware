using Application.BuildingAddresses.Commands.Requests;
using Infrastructure.Responses.BuildingAddressController;
using Application.Responses;
using Application.Users.Commands.Requests;
using AutoMapper;
using Infrastructure.GoogleAPI;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Commands.Handlers
{
    public class UpdateBuildingAddressCommandHandler : IRequestHandler<UpdateBuildingAddressCommand, AddUpdateBuildingAddressReponse>
    {
        private readonly IBuildingAddressRepository _buildingAddressRepository;
        private readonly IMapper _mapper;

        public UpdateBuildingAddressCommandHandler(IBuildingAddressRepository buildingAddressRepository, IMapper mapper)
        {
            _buildingAddressRepository = buildingAddressRepository;
            _mapper = mapper;
        }

        public async Task<AddUpdateBuildingAddressReponse> Handle(UpdateBuildingAddressCommand request, CancellationToken cancellationToken)
        {
            var address = _mapper.Map<BuildingAddress>(request.AddressDTO);


            var buildingAddressFromDB = await _buildingAddressRepository.GetAsync(request.Id, cancellationToken);
            if (buildingAddressFromDB == null)
                throw new Exception($"Nie znaleziono adresu budynku o identyfikatorze {request.Id}.");

            GoogleGeocodingClient client = new GoogleGeocodingClient(address);
            AddUpdateBuildingAddressReponse updateBuildingAddressResponse = await client.SetCoordinatesAndPostalCode(request.UpdateWithNotAccurateCoords);
            if (updateBuildingAddressResponse.WebApiStatus == ProwitechWebAPIStatus.ADDED_TO_DB.ToString()
            || updateBuildingAddressResponse.WebApiStatus == ProwitechWebAPIStatus.ADDED_DESPITE_COORDINATE_ISSUE.ToString())
            {
                //buildingAddressFromDB = updateBuildingAddressResponse.AddedBuildingAddress.DeepCopy();
                //buildingAddressFromDB.Id = request.Id;

                buildingAddressFromDB.CityName = updateBuildingAddressResponse.AddedBuildingAddress.CityName;
                buildingAddressFromDB.StreetName=updateBuildingAddressResponse.AddedBuildingAddress.StreetName;
                buildingAddressFromDB.BuildingNumber = updateBuildingAddressResponse.AddedBuildingAddress.BuildingNumber;
                buildingAddressFromDB.Longitude= updateBuildingAddressResponse.AddedBuildingAddress.Longitude;
                buildingAddressFromDB.Latitude = updateBuildingAddressResponse.AddedBuildingAddress.Latitude;
                buildingAddressFromDB.CoordinateType = updateBuildingAddressResponse.AddedBuildingAddress.CoordinateType;
                buildingAddressFromDB.PostalCode = updateBuildingAddressResponse.AddedBuildingAddress.PostalCode;

                await _buildingAddressRepository.UpdateBuildingAddressAsync(buildingAddressFromDB, cancellationToken);
            }
            else if (updateBuildingAddressResponse.WebApiStatus == ProwitechWebAPIStatus.NOT_ADDED_COORDINATES_TYPE_ISSUE.ToString()
                && request.UpdateWithoutCoords)
            {
                //buildingAddressFromDB = updateBuildingAddressResponse.AddedBuildingAddress.DeepCopy();

                buildingAddressFromDB.CityName = updateBuildingAddressResponse.AddedBuildingAddress.CityName;
                buildingAddressFromDB.StreetName = updateBuildingAddressResponse.AddedBuildingAddress.StreetName;
                buildingAddressFromDB.BuildingNumber = updateBuildingAddressResponse.AddedBuildingAddress.BuildingNumber;
                buildingAddressFromDB.Longitude = null;
                buildingAddressFromDB.Latitude = null;
                buildingAddressFromDB.CoordinateType = null;
                buildingAddressFromDB.PostalCode = updateBuildingAddressResponse.AddedBuildingAddress.PostalCode;
                updateBuildingAddressResponse.WebApiStatus = ProwitechWebAPIStatus.ADDED_TO_DB_WITHOUT_COORDINATES.ToString();
                await _buildingAddressRepository.UpdateBuildingAddressAsync(buildingAddressFromDB, cancellationToken);
            }
            updateBuildingAddressResponse.AddedBuildingAddress.Id=buildingAddressFromDB.Id;
            return updateBuildingAddressResponse;



        }
    }
}
