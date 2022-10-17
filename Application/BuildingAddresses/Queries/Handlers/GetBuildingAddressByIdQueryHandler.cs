using Application.BuildingAddresses.DTOs;
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
    public class GetBuildingAddressByIdQueryHandler : IRequestHandler<GetBuildingAddressByIdQuery, BuildingAddressDTO>
    {

        private readonly IBuildingAddressRepository buildingAddressRepository;
        private readonly IMapper mapper;

        public GetBuildingAddressByIdQueryHandler(IBuildingAddressRepository buildingAddressRepository, IMapper mapper)
        {
            this.buildingAddressRepository = buildingAddressRepository;
            this.mapper = mapper;
        }

        public async Task<BuildingAddressDTO> Handle(GetBuildingAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var address = await buildingAddressRepository.GetAsync(request.Id, cancellationToken);
            if (address == null)
                throw new Exception($"Nie znaleziono adresu budynku o identyfikatorze {request.Id}");
            var addressDTO = mapper.Map<BuildingAddressDTO>(address);
            return addressDTO;
        }
    }
}
