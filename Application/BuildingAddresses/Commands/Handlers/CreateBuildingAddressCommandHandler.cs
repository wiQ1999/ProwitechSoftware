using Application.BuildingAddresses.Commands.Requests;
using Application.Responses;
using Application.Responses.BuildingAddressController;
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

namespace Application.BuildingAddresses.Commands.Handlers
{
    public class CreateBuildingAddressCommandHandler : IRequestHandler<CreateBuildingAddressCommand, AddBuildingAddressResponse>
    {
        private readonly IBuildingAddressRepository buildingAddressRepository;
        private readonly IMapper mapper;

        public CreateBuildingAddressCommandHandler(IBuildingAddressRepository buildingAddressRepository, IMapper mapper)
        {
            this.buildingAddressRepository = buildingAddressRepository;
            this.mapper = mapper;
        }

        public async Task<AddBuildingAddressResponse> Handle(CreateBuildingAddressCommand request, CancellationToken cancellationToken)
        {
            var address = mapper.Map<BuildingAddress>(request.AddressDTO);
            GoogleGeocodingClient client = new GoogleGeocodingClient(address);
            AddBuildingAddressResponse addBuildingAddressResponse = await client.SetCoordinatesAndPostalCode(request.Force);
            if (addBuildingAddressResponse.WebApiStatus == ProwitechWebAPIStatus.ADDED_TO_DB.ToString())
            {
                addBuildingAddressResponse.AddedBuildingAddress
                    = await buildingAddressRepository.AddAsync(addBuildingAddressResponse.AddedBuildingAddress, cancellationToken);
            }
            return addBuildingAddressResponse;
        }
    }
}
