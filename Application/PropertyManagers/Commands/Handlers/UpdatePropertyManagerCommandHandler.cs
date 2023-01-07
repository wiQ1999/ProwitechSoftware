using Application.PropertyManagers.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PropertyManagers.Commands.Handlers
{
    internal class UpdatePropertyManagerCommandHandler : IRequestHandler<UpdatePropertyManagerCommand>
    {
        private readonly IPropertyManagerRepository _propertyManagerRepository;
        private readonly IFullAddressRepository _fullAddressRepository;

        public UpdatePropertyManagerCommandHandler(IPropertyManagerRepository propertyManagerRepository, IFullAddressRepository fullAddressRepository)
        {
            _propertyManagerRepository = propertyManagerRepository;
            _fullAddressRepository = fullAddressRepository;
        }

        public async Task<Unit> Handle(UpdatePropertyManagerCommand command, CancellationToken cancellationToken)
        {
            var pmFromDb = await _propertyManagerRepository.GetAsync(command.Id, cancellationToken);
            if (pmFromDb == null)
                throw new Exception($"W bazie danych nie ma szukanego Zarządcy Nieruchomości, aby móc go edytować");

            pmFromDb.Name = command.Name;
            pmFromDb.PhoneNumber = command.PhoneNumber;

            if (command.UpdateFullAddressDTO != null && pmFromDb.FullAddressId != null)
            {
                FullAddress faFromDB = await _fullAddressRepository.GetAsync(pmFromDb.FullAddressId.Value, cancellationToken);
                if (command.UpdateFullAddressDTO.BuildingAddressId != Guid.Empty)
                    faFromDB.BuildingAddressId = command.UpdateFullAddressDTO.BuildingAddressId;
                faFromDB.PropertyAddress.VenueNumber = command.UpdateFullAddressDTO.VenueNumber;
                faFromDB.PropertyAddress.StaircaseNumber = command.UpdateFullAddressDTO.StaircaseNumber;
                await _fullAddressRepository.UpdateAsync(faFromDB, cancellationToken);

            }
            await _propertyManagerRepository.UpdateAsync(pmFromDb, cancellationToken);


            return Unit.Value;
        }
    }
}
