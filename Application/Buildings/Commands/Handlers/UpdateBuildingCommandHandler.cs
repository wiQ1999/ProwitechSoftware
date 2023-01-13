using Application.Buildings.Commands.Requests;
using Application.Properties.Helpers;
using Infrastructure.Interfaces.Repositories;
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
        private readonly IBuildingRepository _buildingRepository;
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IRealPropertyRepository _propertyRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;

        public UpdateBuildingCommandHandler(IBuildingRepository buildingRepository, IPropertyManagerRepository propertyManagerRepository, IRealPropertyRepository propertyRepository, IPropertyAddressRepository propertyAddressRepository)
        {
            _buildingRepository = buildingRepository;
            _propertyManagerRepository = propertyManagerRepository;
            _propertyRepository = propertyRepository;
            _propertyAddressRepository = propertyAddressRepository;
        }

        public async Task<Unit> Handle(UpdateBuildingCommand request, CancellationToken cancellationToken)
        {
            
                
            var bFromDB = await _buildingRepository.GetAsync(request.Id, cancellationToken);
            if (bFromDB == null)
                throw new Exception($"Brak w bazie danych budynku o Id: {request.Id}");
            if (request.PropertyManagerId != Guid.Empty)
            {
                var pmFromDB = await _propertyManagerRepository.GetAsync(request.PropertyManagerId, cancellationToken);
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
            RealPropertyHelper propertyChanger = new RealPropertyHelper(_propertyRepository, _propertyAddressRepository);
            await propertyChanger.AddOrRemovePropertyBasedOnBuildingType(bFromDB, request.Type, cancellationToken);

            bFromDB.Type = request.Type;
            await _buildingRepository.UpdateBuildingAsync(bFromDB, cancellationToken);
            return Unit.Value;

        }
    }
}
