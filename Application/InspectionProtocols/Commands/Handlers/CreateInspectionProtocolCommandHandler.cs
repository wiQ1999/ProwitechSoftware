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
            var resident = _mapper.Map<Resident>(request.ResidentDTO);
            var inspectionProtocolDTO = request.InspectionProtocolDTO;

            InspectionProtocolGuidsChecker checker = new InspectionProtocolGuidsChecker(_unitOfWork);
            await checker.CheckExistanceOfGuidsInDB(inspectionProtocolDTO, "dodać", cancellationToken);

            InspectionProtocolCRUDHelper.CheckIfAllAnswersAreCorrect(inspectionProtocolDTO);
            InspectionProtocol inspectionProtocol = _mapper.Map<InspectionProtocol>(inspectionProtocolDTO);

            var residentId = await _unitOfWork.ResidentsRepository.CreateOrGetResident(resident, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            inspectionProtocol.ResidentId=residentId;
            inspectionProtocol.Number = request.Number;

            var protocolId = await _unitOfWork.InspectionProtocolsRepository.AddAsync(inspectionProtocol, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return protocolId;
        }
    }
}
