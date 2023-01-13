using Application.Buildings.DTOs;
using Application.InspectionTasks.DTOs;
using Application.InspectionTasks.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Handlers
{
    public class GetAllInspectionTasksQueryHandler:IRequestHandler<GetAllInspectionTasksQuery, IEnumerable<AllInspectionTasksDTO>>
    {
        private readonly IInspectionTaskRepository _inspectionTaskRepository;
        private readonly IMapper _mapper;

        public GetAllInspectionTasksQueryHandler(IInspectionTaskRepository inspectionTaskRepository, IMapper mapper)
        {
            _inspectionTaskRepository = inspectionTaskRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllInspectionTasksDTO>> Handle(GetAllInspectionTasksQuery request, CancellationToken cancellationToken)
        {
            var inspectionTasks = await _inspectionTaskRepository.GetAllAsync(cancellationToken);
            var inspectionTasksDTOs=_mapper.Map<List<AllInspectionTasksDTO>>(inspectionTasks);
            return inspectionTasksDTOs;
        }
    }
}
