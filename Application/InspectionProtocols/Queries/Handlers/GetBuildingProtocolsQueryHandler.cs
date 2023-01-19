using Application.InspectionProtocols.DTOs;
using Application.InspectionProtocols.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Queries.Handlers
{
    public class GetBuildingProtocolsQueryHandler : IRequestHandler<GetBuildingProtocolsQuery, IEnumerable<AllInspectionProtocolsDTO>>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBuildingProtocolsQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllInspectionProtocolsDTO>> Handle(GetBuildingProtocolsQuery request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.BuildingRepository.GetAsync(request.BuildingId, cancellationToken) == null)
                throw new Exception($"Nie można pobrać protokołu wybranego budynku: Budynek o ID: {request.BuildingId} nie isnieje");
            var protocols = await _unitOfWork.InspectionProtocolsRepository.GetProtocolsOfParticularBuilding(request.BuildingId, cancellationToken);
            return _mapper.Map<List<AllInspectionProtocolsDTO>>(protocols);
        }
    }
}
