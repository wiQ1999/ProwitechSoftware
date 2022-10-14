﻿using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Queries.Handlers
{
    public class GetBuildingAddressesQueryHandler : IRequestHandler<GetBuildingAddressesQuery, IEnumerable<BuildingAddressDTO>>
    {
        private readonly IBuildingAddressRepository buildingAddressRepository;
        private readonly IMapper mapper;

        public GetBuildingAddressesQueryHandler(IBuildingAddressRepository buildingAddressRepository, IMapper mapper)
        {
            this.buildingAddressRepository = buildingAddressRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<BuildingAddressDTO>> Handle(GetBuildingAddressesQuery request, CancellationToken cancellationToken)
        {
            var buildingAddresses = await buildingAddressRepository.GetAllAsync(cancellationToken);

            var buildingAddressesDTOs = mapper.Map<List<BuildingAddressDTO>>(buildingAddresses);
            return buildingAddressesDTOs;
        }
    }
}
