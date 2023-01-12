using Application.InspectionTasks.DTOs;
using Application.InspectionTasks.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Handlers
{
    public class GetInspectionTaskByIdQueryHandler : IRequestHandler<GetInspectionTaskByIdQuery, InspectionTaskByIdDTO>
    {
        private readonly IInspectionTaskRepository _inspectionTaskRepository;
        private readonly IMapper _mapper;

        public GetInspectionTaskByIdQueryHandler(IInspectionTaskRepository inspectionTaskRepository, IMapper mapper)
        {
            _inspectionTaskRepository = inspectionTaskRepository;
            _mapper = mapper;
        }

        public async Task<InspectionTaskByIdDTO> Handle(GetInspectionTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var iT=await _inspectionTaskRepository.GetAsync(request.Id, cancellationToken);
            var mapped= _mapper.Map<InspectionTaskByIdDTO>(iT);
            return mapped;
            return _mapper.Map<InspectionTaskByIdDTO>(iT);
        }
    }
}
