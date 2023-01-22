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
    public class GetPerformerProtocolsQueryHandler : IRequestHandler<GetPerformerProtocolsQuery, IEnumerable<AllInspectionProtocolsDTO>>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPerformerProtocolsQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllInspectionProtocolsDTO>> Handle(GetPerformerProtocolsQuery request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.UsersRepository.GetByIdAsync(request.PerformerId, cancellationToken) == null)
                throw new Exception($"Nie można pobrać protokołu wybranego Inspektora:" +
                    $" Inspektor o ID: {request.PerformerId} nie istnieje");
            var protocols = await _unitOfWork.InspectionProtocolsRepository.
                GetInspectionProtocolsOfParticularPerformer(request.PerformerId, cancellationToken);
            return _mapper.Map<List<AllInspectionProtocolsDTO>>(protocols);
        }
    }
}
