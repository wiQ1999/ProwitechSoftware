using Application.Buildings.DTOs;
using Application.Buildings.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Queries.Handlers
{
    public class GetBuildingByIdQueryHandler : IRequestHandler<GetBuildingByIdQuery, BuildingByIdDTO>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly IMapper _mapper;
        private readonly IPropertyRepository _propertyRepository;

        public GetBuildingByIdQueryHandler(IBuildingRepository buildingRepository, IMapper mapper, IPropertyRepository propertyRepository)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
            _propertyRepository = propertyRepository;
        }

        public async Task<BuildingByIdDTO> Handle(GetBuildingByIdQuery request, CancellationToken cancellationToken)
        {
            Building b = await _buildingRepository.GetAsync(request.Id, cancellationToken);
            if (b == null)
                throw new Exception($"Brak w bazie danych Budynku o Id: {request.Id}");
            return _mapper.Map<BuildingByIdDTO>(b);
        }
    }
}
