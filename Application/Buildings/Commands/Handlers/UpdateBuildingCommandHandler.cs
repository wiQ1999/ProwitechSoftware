using Application.Buildings.Commands.Requests;
using Application.RealProperties.Helpers;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Buildings.Commands.Handlers
{
    public class UpdateBuildingCommandHandler : IRequestHandler<UpdateBuildingCommand>
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public UpdateBuildingCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateBuildingCommand request, CancellationToken cancellationToken)
        {
            
                
            var bFromDB = await _unitOfWork.BuildingRepository.GetAsync(request.Id, cancellationToken);
            if (bFromDB == null)
                throw new Exception($"Brak w bazie danych budynku o Id: {request.Id}");
            if (request.PropertyManagerId != Guid.Empty)
            {
                var pmFromDB = await _unitOfWork.PropertyManagerRepository.GetAsync(request.PropertyManagerId, cancellationToken);
                if (pmFromDB == null)
                    throw new Exception($"Brak w bazie danych Zarządcy Nieruchomości o Id: {request.PropertyManagerId}");
                bFromDB.PropertyManagerId = request.PropertyManagerId;
            }
            else
            {
                bFromDB.PropertyManagerId = null;
            }
            //TODO SPRAWDZIĆ CZY TEN IF DOBRZE DZIAŁA PRZY WIELOLOKALOWY
            if(bFromDB.Properties!=null
                && bFromDB.Properties.Count > 0 
                && bFromDB.Type==BuildingType.WIELOLOKALOWY.ToString()
                && request.Type==BuildingType.JEDNOLOKALOWY.ToString())
            {
                throw new Exception($"Nie możesz zmienić typu budynku na jednolokalowy, ponieważ są już do niego przypisane lokale");
            }
            //TODO IF BUILDINGTYPE==JEDNOLOKALOWY && PROPERTY MA PRZYPISANY RAPORT - NIE WOLNO JUŻ NIC ZMIENIĆ
            // NAJPIERW TRZEBA USUNĄĆ RAPORT
            RealPropertyHelper propertyChanger = new RealPropertyHelper(_unitOfWork);
            await propertyChanger.AddOrRemovePropertyBasedOnBuildingType(bFromDB, request.Type, cancellationToken);

            bFromDB.Type = request.Type;
            await _unitOfWork.BuildingRepository.UpdateBuildingAsync(bFromDB, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;

        }
    }
}
