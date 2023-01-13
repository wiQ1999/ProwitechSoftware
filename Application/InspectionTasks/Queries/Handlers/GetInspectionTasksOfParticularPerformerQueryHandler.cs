using Application.InspectionTasks.DTOs;
using Application.InspectionTasks.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Handlers
{
    internal class GetInspectionTasksOfParticularPerformerQueryHandler :
        IRequestHandler<GetInspectionTasksOfParticularPerformerQuery, IEnumerable<AllInspectionTasksDTO>>
    {

        private readonly IInspectionTaskRepository _inspectionTaskRepository;
        private readonly IMapper _mapper;

        public GetInspectionTasksOfParticularPerformerQueryHandler(IInspectionTaskRepository inspectionTaskRepository, IMapper mapper)
        {
            _inspectionTaskRepository = inspectionTaskRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllInspectionTasksDTO>> Handle(GetInspectionTasksOfParticularPerformerQuery request, CancellationToken cancellationToken)
        {
            var tasks = await _inspectionTaskRepository.GetTasksOfParticularPerformer(request.Id, cancellationToken);
            return _mapper.Map<List<AllInspectionTasksDTO>>(tasks);
        }
    }
}
