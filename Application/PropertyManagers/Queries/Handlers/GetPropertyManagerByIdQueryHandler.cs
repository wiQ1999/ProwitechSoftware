using Application.PropertyManagers.DTOs;
using Application.PropertyManagers.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
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
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IMapper _mapper;

        public GetPropertyManagerByIdQueryHandler(IPropertyManagerRepository propertyManagerRepository, IMapper mapper)
        {
            _propertyManagerRepository = propertyManagerRepository;
            _mapper = mapper;
        }

        public async Task<PropertyManagerDTO> Handle(GetPropertyManagerByIdQuery request, CancellationToken cancellationToken)
        {
            var pm = await _propertyManagerRepository.GetAsync(request.Id, cancellationToken);
            if (pm == null)
                throw new Exception($"W bazie danych nie ma Zarządcy Nieruchomości o id: {request.Id}");
            return _mapper.Map<PropertyManagerDTO>(pm);
        }
    }
}
