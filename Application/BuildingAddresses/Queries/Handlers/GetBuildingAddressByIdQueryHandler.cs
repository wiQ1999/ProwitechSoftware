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
    public class GetBuildingAddressByIdQueryHandler : IRequestHandler<GetBuildingAddressByIdQuery, BuildingAddressDTO>
    {

        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public GetBuildingAddressByIdQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<BuildingAddressDTO> Handle(GetBuildingAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var address = await _unitOfWork.BuildingAddressRepository.GetAsync(request.Id, cancellationToken);
            if (address == null)
                throw new Exception($"Nie znaleziono adresu budynku o identyfikatorze {request.Id}");
            var addressDTO = mapper.Map<BuildingAddressDTO>(address);
            return addressDTO;
        }
    }
}
