using Application.InspectionProtocols.DTOs;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.InspectionProtocolAnswers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InspectionProtocols.Helpers
{
    public class InspectionProtocolGuidsChecker
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public InspectionProtocolGuidsChecker(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CheckExistanceOfGuidsInDB(CreateOrUpdateInspectionProtocolDTO protocol, string whatToDo, CancellationToken cancellationToken)
        {
            if (protocol.InspectionTaskId!=null && await _unitOfWork.InspectionTaskRepository.GetAsync(protocol.InspectionTaskId.Value, cancellationToken) == null)
                throw new Exception($"Nie można {whatToDo} Protokołu Inspekcji - w bazie danych brak Zadania o ID: {protocol.InspectionTaskId}");
            if (await _unitOfWork.RealPropertyRepository.GetAsync(protocol.InspectedPropertyId, cancellationToken) == null)
                throw new Exception($"Nie można {whatToDo} Protokołu Inspekcji - w bazie danych brak Nieruchomości o ID: {protocol.InspectedPropertyId}");
            if (await _unitOfWork.UsersRepository.GetByIdAsync(protocol.InspectionPerformerId, cancellationToken) == null)
                throw new Exception($"Nie można {whatToDo} Protokołu Inspekcji - w bazie danych brak Użytkownika o ID: {protocol.InspectionPerformerId}");
            if (protocol.InspectionTaskId != null)
            {
                Guid taskId = protocol.InspectionTaskId.Value;
                Guid propertyId = protocol.InspectedPropertyId;
                var inspectionTaskFromDB = await _unitOfWork.InspectionTaskRepository.GetAsync(taskId, cancellationToken);
                var buildingIdAssignedToTask = inspectionTaskFromDB.BuildingId;

                var realPropertyFromDB = await _unitOfWork.RealPropertyRepository.GetAsync(propertyId, cancellationToken);
                var buildingIdAssignedToProperty = realPropertyFromDB!.BuildingId;

                if(buildingIdAssignedToTask!=buildingIdAssignedToProperty)
                    throw new Exception($"Nie można {whatToDo} Protokołu Inspekcji - ID budynku przypisanego do zadania " +
                        $"i budynku przypisanego do Nieruchomości nie są takie same");
            }
        }
    }
}
