using Application.InspectionTasks.DTOs;
using Application.InspectionTasks.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Handlers
{
    public class GetInspectionTaskByIdQueryHandler : IRequestHandler<GetInspectionTaskByIdQuery, InspectionTaskByIdDTO>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetInspectionTaskByIdQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InspectionTaskByIdDTO> Handle(GetInspectionTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var iT=await _unitOfWork.InspectionTaskRepository.GetAsync(request.Id, cancellationToken);

            //TODO get properties without protocols
            //var building = await _unitOfWork.BuildingRepository.GetAsync(iT.BuildingId, cancellationToken);
            //var buildingProperties = building.Properties;

            //ICollection<RealProperty> propertiesWithProtocols = new Collection<RealProperty>();

            //foreach(var prot in iT.InspectionProtocols)
            //{
            //    propertiesWithProtocols.Add(prot.InspectedProperty);
            //}
            //var propertiesWithoutProtocols = buildingProperties.Except(propertiesWithProtocols);
            var mapped= _mapper.Map<InspectionTaskByIdDTO>(iT);
            return mapped;
        }
    }
}
