using Application.BuildingAddresses.DTOs;
using Application.BuildingAddresses.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BuildingAddresses.Queries.Handlers
{
    public class GetAllBuildingAddressesQueryHandler : IRequestHandler<GetAllBuildingAddressesQuery, IEnumerable<BuildingAddressDTO>>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public GetAllBuildingAddressesQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<BuildingAddressDTO>> Handle(GetAllBuildingAddressesQuery request, CancellationToken cancellationToken)
        {
            var buildingAddresses = await _unitOfWork.BuildingAddressRepository.GetAllAsync(cancellationToken);

            var buildingAddressesDTOs = mapper.Map<List<BuildingAddressDTO>>(buildingAddresses);
            return buildingAddressesDTOs;
        }
    }
}
