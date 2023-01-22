using Application.InspectionProtocols.DTOs;
using Application.InspectionTasks.Queries.Requests;
using Application.RealProperties.DTOs;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionTasks.Queries.Handlers
{
    public class GetTaskRealPropertiesWhichDontHaveProtocolsQueryHandler :
        IRequestHandler<GetTaskRealPropertiesWhichDontHaveProtocolsQuery, IEnumerable<AllRealPropertiesDTO>>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTaskRealPropertiesWhichDontHaveProtocolsQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllRealPropertiesDTO>> Handle(GetTaskRealPropertiesWhichDontHaveProtocolsQuery request, CancellationToken cancellationToken)
        {
            var iT = await _unitOfWork.InspectionTaskRepository.GetAsync(request.TaskId, cancellationToken);
            if (iT == null)
                throw new Exception($"Nie można pobrać Nieruchomości, które nie mają przypisanych protokołów" +
                    $" i które należą do Zadania: Zadanie o ID: {request.TaskId} nie istnieje");

            var building = await _unitOfWork.BuildingRepository.GetAsync(iT.BuildingId, cancellationToken);
            var buildingProperties = building.Properties;

            
            ICollection<RealProperty> propertiesWithProtocols = new Collection<RealProperty>();
            IEnumerable<RealProperty> propertiesWithoutProtocols = new List<RealProperty>();

            if(iT.InspectionProtocols==null || iT.InspectionProtocols.Count==0)
                propertiesWithoutProtocols = buildingProperties!;
            else
            {
                foreach (var prot in iT.InspectionProtocols)
                {
                    propertiesWithProtocols.Add(prot.InspectedProperty);
                }
                propertiesWithoutProtocols = buildingProperties!.Except(propertiesWithProtocols);
            }

            return _mapper.Map<List<AllRealPropertiesDTO>>(propertiesWithoutProtocols);


        }
    }
}
