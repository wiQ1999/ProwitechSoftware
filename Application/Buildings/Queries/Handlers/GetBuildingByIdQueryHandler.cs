﻿using Application.Buildings.DTOs;
using Application.Buildings.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Queries.Handlers
{
    public class GetBuildingByIdQueryHandler : IRequestHandler<GetBuildingByIdQuery, BuildingByIdDTO>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBuildingByIdQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BuildingByIdDTO> Handle(GetBuildingByIdQuery request, CancellationToken cancellationToken)
        {
            Building b = await _unitOfWork.BuildingRepository.GetAsync(request.Id, cancellationToken);
            if (b == null)
                throw new Exception($"Brak w bazie danych Budynku o Id: {request.Id}");
            return _mapper.Map<BuildingByIdDTO>(b);
        }
    }
}
