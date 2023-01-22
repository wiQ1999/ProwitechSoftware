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
    public class GetTaskProtocolsQueryHandler : IRequestHandler<GetTaskProtocolsQuery, IEnumerable<AllInspectionProtocolsDTO>>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTaskProtocolsQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllInspectionProtocolsDTO>> Handle(GetTaskProtocolsQuery request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.InspectionTaskRepository.GetAsync(request.InspectionTaskId, cancellationToken) == null)
                throw new Exception($"Nie można pobrać protokołu wybranego Zadania:" +
                    $" Zadanie o ID: {request.InspectionTaskId} nie isnieje");
            var protocols = await _unitOfWork.InspectionProtocolsRepository.
                GetInspectionProtocolsOfParticularTask(request.InspectionTaskId, cancellationToken);
            return _mapper.Map<List<AllInspectionProtocolsDTO>>(protocols); 
        }
    }
}
