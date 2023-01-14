using Application.InspectionTasks.DTOs;
using Application.InspectionTasks.Helpers;
using Application.InspectionTasks.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Handlers
{
    public class GetInspectionTasksOfParticularPerformerAndStatusQueryHandler :
        IRequestHandler<GetInspectionTasksOfParticularPerformerAndStatusQuery, IEnumerable<AllInspectionTasksDTO>>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetInspectionTasksOfParticularPerformerAndStatusQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllInspectionTasksDTO>> Handle(GetInspectionTasksOfParticularPerformerAndStatusQuery request, CancellationToken cancellationToken)
        {
            if (!InspectionTaskHelper.isStatusAllowed(request.Status))
                throw new Exception
                    ($"Nie pobrać zadań konkretnego użytkownika o konkretnym statusie: Niedozwolony status");

            var tasks = await _unitOfWork.InspectionTaskRepository
                .GetTasksOfParticularPerformerWithParticularStatus(request.Id, request.Status, cancellationToken);
            return _mapper.Map<List<AllInspectionTasksDTO>>(tasks);
        }
    }
}
