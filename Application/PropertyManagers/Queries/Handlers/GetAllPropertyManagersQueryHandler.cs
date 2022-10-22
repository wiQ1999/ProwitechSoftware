using Application.BuildingAddresses.DTOs;
using Application.PropertyManagers.DTOs;
using Application.PropertyManagers.Queries.Requests;
using Application.Users.DTOs;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.Queries.Handlers
{
    public class GetAllPropertyManagersQueryHandler : IRequestHandler<GetAllPropertyManagersQuery, IEnumerable<PropertyManagerDTO>>
    {
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IMapper _mapper;

        public GetAllPropertyManagersQueryHandler(IPropertyManagerRepository propertyManagerRepository, IMapper mapper)
        {
            _propertyManagerRepository = propertyManagerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PropertyManagerDTO>> Handle(GetAllPropertyManagersQuery request, CancellationToken cancellationToken)
        {
           
            var managers = await _propertyManagerRepository.GetAllAsync(cancellationToken);
            var managersDTOs = _mapper.Map<List<PropertyManagerDTO>>(managers);
            return managersDTOs;
        }
    }
}
