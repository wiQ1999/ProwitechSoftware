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
        //private readonly IMapper _mapper;
        private readonly IPropertyRepository _propertyRepository;

        public GetBuildingByIdQueryHandler(IBuildingRepository buildingRepository, IPropertyRepository propertyRepository)
        {
            _buildingRepository = buildingRepository;
            _propertyRepository = propertyRepository;
        }

        public async Task<BuildingByIdDTO> Handle(GetBuildingByIdQuery request, CancellationToken cancellationToken)
        {
            Building b = await _buildingRepository.GetAsync(request.Id, cancellationToken);
            if (b == null)
                throw new Exception($"Brak w bazie danych Budynku o Id: {request.Id}");
            IEnumerable<Property> properties = await _propertyRepository.GetAllPropertiesOfBuilding(b.Id, cancellationToken);
            BuildingByIdDTO bDTO;
            if (properties != null)
            {
                bDTO = new BuildingByIdDTO()
                {
                    Building = b,
                    Properties = properties
                };
            }
            else
            {
                bDTO = new BuildingByIdDTO()
                {
                    Building = b,
                    Properties = properties
                };
            }
            return bDTO;
        }
    }
}
