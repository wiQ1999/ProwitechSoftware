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
            if (await _unitOfWork.InspectionProtocolsRepository.GetAsync(protocolId, cancellationToken) == null)
                throw new Exception($"Nie można edytować Protokołu - w bazie danych nie istnieje protokół o ID: {protocolId}");
            var updatedResident = _mapper.Map<Resident>(request.Resident);
            var inspectionProtocolDTO = request.InspectionProtocolDTO;


            Resident? oldResidentFromDB = await _unitOfWork.ResidentsRepository.GetAsync(updatedResident.Id, cancellationToken); 
            if (oldResidentFromDB == null)
                throw new Exception($"Nie można edytować Mieszkańca Nieruchomości: W bazie danych nie istnieje Mieszkaniec o ID: {updatedResident.Id}");


            var residentId = await _unitOfWork.ResidentsRepository.UpdateOrGetResident(updatedResident, oldResidentFromDB, protocolId, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);


            await CheckExistanceOfGuidsInDB(request.InspectionProtocolDTO, cancellationToken);
            InspectionProtocolCRUDHelper.CheckIfAllAnswersAreCorrect(inspectionProtocolDTO);


            InspectionProtocol inspectionProtocol = _mapper.Map<InspectionProtocol>(inspectionProtocolDTO);
            inspectionProtocol.ResidentId = residentId;
            await _unitOfWork.InspectionProtocolsRepository.UpdateAsync(inspectionProtocol, cancellationToken);

            return Unit.Value;
        }
        public async Task CheckExistanceOfGuidsInDB(CreateOrUpdateInspectionProtocolDTO protocol, CancellationToken cancellationToken)
        {
            if (protocol.InspectionTaskId!=Guid.Empty
                && await _unitOfWork.InspectionTaskRepository.GetAsync(protocol.InspectionTaskId.Value, cancellationToken) == null)
                throw new Exception($"Nie można edytować Protokołu Inspekcji - w bazie danych brak Zadania o ID: {protocol.InspectionTaskId}");
            if(await _unitOfWork.RealPropertyRepository.GetAsync(protocol.InspectedPropertyId, cancellationToken)==null)
                throw new Exception($"Nie można edytować Protokołu Inspekcji - w bazie danych brak Nieruchomości o ID: {protocol.InspectedPropertyId}");
            if (await _unitOfWork.UsersRepository.GetByIdAsync(protocol.InspectionPerformerId, cancellationToken) == null)
                throw new Exception($"Nie można edytować Protokołu Inspekcji - w bazie danych brak Użytkownika o ID: {protocol.InspectionPerformerId}");
        }

    }
}
