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
    public class GetRealPropertyByIdQueryHandler : IRequestHandler<GetRealPropertyByIdQuery, AllRealPropertiesDTO>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetRealPropertyByIdQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<AllRealPropertiesDTO> Handle(GetRealPropertyByIdQuery request, CancellationToken cancellationToken)
        {
            var realProp = await _unitOfWork.RealPropertyRepository.GetAsync(request.Id, cancellationToken);
            var realPropDTO = _mapper.Map<AllRealPropertiesDTO>(realProp);
            return realPropDTO;
        }
    }
}
