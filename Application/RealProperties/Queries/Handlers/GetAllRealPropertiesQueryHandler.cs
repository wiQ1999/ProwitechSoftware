using Application.RealProperties.DTOs;
using Application.RealProperties.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RealProperties.Queries.Handlers
{
    public class GetAllRealPropertiesQueryHandler : IRequestHandler<GetAllRealPropertiesQuery, IEnumerable<AllRealPropertiesDTO>>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllRealPropertiesQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AllRealPropertiesDTO>> Handle(GetAllRealPropertiesQuery request, CancellationToken cancellationToken)
        {
            var realProperties = await _unitOfWork.RealPropertyRepository.GetAllAsync(cancellationToken);
            var realPropDTOs = _mapper.Map<List<AllRealPropertiesDTO>>(realProperties);
            return realPropDTOs;
        }
    }
}
