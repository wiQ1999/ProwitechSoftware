using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using Application.Buildings.DTOs;
using Application.Buildings.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Queries.Handlers
{
    public class GetAllBuildingsQueryHandler : IRequestHandler<GetAllBuildingsQuery, IEnumerable<AllBuildingsDTO>>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly IMapper _mapper;

        public GetAllBuildingsQueryHandler(IBuildingRepository buildingRepository, IMapper mapper)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllBuildingsDTO>> Handle(GetAllBuildingsQuery request, CancellationToken cancellationToken)
        {
            var buildings = await _buildingRepository.GetAllAsync(cancellationToken);
            var buldingsDTOs = _mapper.Map<List<AllBuildingsDTO>>(buildings);
            return buldingsDTOs;
        }
    }
}
