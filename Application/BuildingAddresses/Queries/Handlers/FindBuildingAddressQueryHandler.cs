using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Queries.Handlers
{
    public class FindBuildingAddressQueryHandler:IRequestHandler<FindBuildingAddressQuery, BuildingAddressDTO>
    {
        private readonly IBuildingAddressRepository buildingAddressRepository;
        private readonly IMapper mapper;

        public FindBuildingAddressQueryHandler(IBuildingAddressRepository buildingAddressRepository, IMapper mapper)
        {
            this.buildingAddressRepository = buildingAddressRepository;
            this.mapper = mapper;
        }

        public async Task<BuildingAddressDTO> Handle(FindBuildingAddressQuery request, CancellationToken cancellationToken)
        {
            BuildingAddress buildingAddress = new BuildingAddress()
            {
                CityName=request.CityName,
                StreetName=request.StreetName,
                BuildingNumber=request.BuildingNumber
            };
            var buildingAddressFromDB = await buildingAddressRepository.FindBuildingAddress(buildingAddress, cancellationToken);
            if (buildingAddressFromDB == null)
                return null;
            var addressDTO = mapper.Map<BuildingAddressDTO>(buildingAddressFromDB);
            return addressDTO;
        }
    }
}
