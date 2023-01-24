using Application.InspectionProtocols.DTOs;
using Application.InspectionProtocols.Queries.Requests;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Queries.Handlers
{
    public class GetInspectionProtocolByIdQueryHandler : IRequestHandler<GetInspectionProtocolByIdQuery, InspectionProtocolByIdDTO>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetInspectionProtocolByIdQueryHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InspectionProtocolByIdDTO> Handle(GetInspectionProtocolByIdQuery request, CancellationToken cancellationToken)
        {
            var iP = await _unitOfWork.InspectionProtocolsRepository.GetAsync(request.Id, cancellationToken);

            CreateOrUpdateInspectionProtocolDTO protocol = _mapper.Map<CreateOrUpdateInspectionProtocolDTO>(iP);
            InspectionProtocolByIdDTO iPDTO = new InspectionProtocolByIdDTO()
            {
                Id = iP.Id,
                Number = iP.Number,
                ResidentDTO = iP.Resident!,
                InspectionProtocolDTO = protocol
            };
            return iPDTO;
        }
    }
}
