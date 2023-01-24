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
using System.Reflection;
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
            var updatedResident = _mapper.Map<Resident>(request.ResidentDTO);
            var inspectionProtocolDTO = request.InspectionProtocolDTO;

            InspectionProtocol updatedProtocol = _mapper.Map<InspectionProtocol>(inspectionProtocolDTO);

            InspectionProtocol? protocolFromDB = await _unitOfWork.InspectionProtocolsRepository.GetAsync(protocolId, cancellationToken);

            if (protocolFromDB == null)
                throw new Exception($"Nie można edytować Protokołu - w bazie danych nie istnieje protokół o ID: {protocolId}");

            await _unitOfWork.InspectionProtocolsRepository.CheckIfInspectionProtocolWithThisNumberExists(protocolId, protocolNumber, cancellationToken);


            Resident? oldResidentFromDB = await _unitOfWork.ResidentsRepository.GetAsync(updatedResident.Id, cancellationToken); 
            if (oldResidentFromDB == null)
                throw new Exception($"Nie można edytować Mieszkańca Nieruchomości przypisanego do Protokołu: W bazie danych nie istnieje Mieszkaniec o ID: {updatedResident.Id}");

            InspectionProtocolGuidsChecker checker = new InspectionProtocolGuidsChecker(_unitOfWork);
            await checker.CheckExistanceOfGuidsInDB(inspectionProtocolDTO, "edytować",cancellationToken);

            InspectionProtocolCRUDHelper.CheckIfAllAnswersAreCorrect(inspectionProtocolDTO);

            updatedResident.Id = Guid.Empty;
            var residentId = await _unitOfWork.ResidentsRepository.UpdateOrGetOrCreateResident(updatedResident, oldResidentFromDB, protocolId, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            foreach (PropertyInfo property in typeof(InspectionProtocol).GetProperties().Where(p => p.CanWrite))
            {
                property.SetValue(protocolFromDB, property.GetValue(updatedProtocol, null), null);
            }
            protocolFromDB.Id = protocolId;
            protocolFromDB.ResidentId = residentId;

            var newOrOldResident = await _unitOfWork.ResidentsRepository.GetAsync(protocolFromDB.ResidentId.Value, cancellationToken);

            protocolFromDB.Resident = newOrOldResident;
            protocolFromDB.Number = protocolNumber;
            await _unitOfWork.InspectionProtocolsRepository.UpdateAsync(protocolFromDB, oldResidentFromDB.Id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
        

    }
}
