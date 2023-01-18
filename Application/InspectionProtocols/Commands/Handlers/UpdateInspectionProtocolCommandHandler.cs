using Application.InspectionProtocols.Commands.Requests;
using Application.InspectionProtocols.DTOs;
using Application.InspectionProtocols.Helpers;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Commands.Handlers
{
    public class UpdateInspectionProtocolCommandHandler : IRequestHandler<UpdateInspectionProtocolCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateInspectionProtocolCommandHandler(IRepositoriesUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateInspectionProtocolCommand request, CancellationToken cancellationToken)
        {
            var protocolId = request.Id;
            var protocolNumber = request.Number;
            var updatedResident = _mapper.Map<Resident>(request.Resident);
            var inspectionProtocolDTO = request.InspectionProtocolDTO; 

            if (await _unitOfWork.InspectionProtocolsRepository.GetAsync(protocolId, cancellationToken) == null)
                throw new Exception($"Nie można edytować Protokołu - w bazie danych nie istnieje protokół o ID: {protocolId}");
            

            Resident? oldResidentFromDB = await _unitOfWork.ResidentsRepository.GetAsync(updatedResident.Id, cancellationToken); 
            if (oldResidentFromDB == null)
                throw new Exception($"Nie można edytować Mieszkańca Nieruchomości przypisanego do Protokołu: W bazie danych nie istnieje Mieszkaniec o ID: {updatedResident.Id}");

            InspectionProtocolGuidsChecker checker = new InspectionProtocolGuidsChecker(_unitOfWork);
            await checker.CheckExistanceOfGuidsInDB(inspectionProtocolDTO, "edytować",cancellationToken);

            InspectionProtocolCRUDHelper.CheckIfAllAnswersAreCorrect(inspectionProtocolDTO);


            var residentId = await _unitOfWork.ResidentsRepository.UpdateOrGetOrCreateResident(updatedResident, oldResidentFromDB, protocolId, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);            


            InspectionProtocol inspectionProtocol = _mapper.Map<InspectionProtocol>(inspectionProtocolDTO);
            inspectionProtocol.ResidentId = residentId;

            //await _unitOfWork.InspectionProtocolsRepository.CheckIfInspectionProtocolWithThisNumberExists(inspectionProtocol, protocolNumber,cancellationToken);

            inspectionProtocol.Number = protocolNumber;

            await _unitOfWork.InspectionProtocolsRepository.UpdateAsync(inspectionProtocol, oldResidentFromDB.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
        

    }
}
