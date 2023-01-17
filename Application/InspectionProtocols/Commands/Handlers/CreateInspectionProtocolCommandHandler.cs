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
            var inspectionProtocolDTO = request.InspectionProtocolDTO;
            
            
            
            InspectionProtocolCRUDHelper.CheckIfAllAnswersAreCorrect(inspectionProtocolDTO);



            InspectionProtocol ip = _mapper.Map<InspectionProtocol>(inspectionProtocolDTO);

            var protocolId = await _unitOfWork.InspectionProtocolsRepository.AddAsync(ip, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return protocolId;
        }
    }
}
