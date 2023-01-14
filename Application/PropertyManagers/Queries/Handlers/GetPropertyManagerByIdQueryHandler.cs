using Application.PropertyManagers.DTOs;
using Application.PropertyManagers.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.Queries.Handlers
{
    public class GetPropertyManagerByIdQueryHandler : IRequestHandler<GetPropertyManagerByIdQuery, PropertyManagerDTO>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPropertyManagerByIdQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PropertyManagerDTO> Handle(GetPropertyManagerByIdQuery request, CancellationToken cancellationToken)
        {
            var pm = await _unitOfWork.PropertyManagerRepository.GetAsync(request.Id, cancellationToken);
            if (pm == null)
                throw new Exception($"W bazie danych nie ma Zarządcy Nieruchomości o id: {request.Id}");
            return _mapper.Map<PropertyManagerDTO>(pm);
        }
    }
}
