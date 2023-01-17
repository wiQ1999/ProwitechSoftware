using Application.InspectionProtocols.Commands.Requests;
using Application.InspectionProtocols.Helpers;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Commands.Handlers
{
    public class CreateInspectionProtocolCommandHandler : IRequestHandler<CreateInspectionProtocolCommand, Guid>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateInspectionProtocolCommandHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateInspectionProtocolCommand request, CancellationToken cancellationToken)
        {
            InspectionProtocolCRUDHelper.CheckIfAllAnswersAreCorrect(request.InspectionProtocolDTO);

            InspectionProtocol ip = _mapper.Map<InspectionProtocol>(request.InspectionProtocolDTO);

            var protocolId = await _unitOfWork.InspectionProtocolsRepository.AddAsync(ip, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return protocolId;
        }
    }
}
