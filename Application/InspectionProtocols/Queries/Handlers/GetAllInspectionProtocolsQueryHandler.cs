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
    public class GetAllInspectionProtocolsQueryHandler : IRequestHandler<GetAllInspectionProtocolsQuery, IEnumerable<AllInspectionProtocolsDTO>>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllInspectionProtocolsQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllInspectionProtocolsDTO>> Handle(GetAllInspectionProtocolsQuery request, CancellationToken cancellationToken)
        {
            var protocols = await _unitOfWork.InspectionProtocolsRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<List<AllInspectionProtocolsDTO>>(protocols);
        }
    }
}
