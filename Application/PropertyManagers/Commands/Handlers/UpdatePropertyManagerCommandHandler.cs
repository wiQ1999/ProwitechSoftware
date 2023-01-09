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
        private readonly IPropertyAddressRepository _propertyAddressRepository;

        public UpdatePropertyManagerCommandHandler(IPropertyManagerRepository propertyManagerRepository, IFullAddressRepository fullAddressRepository, IPropertyAddressRepository propertyAddressRepository)
        {
            _propertyManagerRepository = propertyManagerRepository;
            _fullAddressRepository = fullAddressRepository;
            _propertyAddressRepository = propertyAddressRepository;
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

                //nowy PropertyAddress != null
                if (command.UpdateFullAddressDTO.PropertyAddress != null)
                {
                    //stary PropertyAddress!=null
                    if (faFromDB.PropertyAddress != null)
                    {
                        faFromDB.PropertyAddress.VenueNumber = command.UpdateFullAddressDTO.PropertyAddress.VenueNumber;
                        faFromDB.PropertyAddress.StaircaseNumber = command.UpdateFullAddressDTO.PropertyAddress.StaircaseNumber;
                    }
                    //stary PropertyAddress == null
                    else
                    {
                        var propAddress = new PropertyAddress()
                        {
                            VenueNumber = command.UpdateFullAddressDTO.PropertyAddress.VenueNumber,
                            StaircaseNumber = command.UpdateFullAddressDTO.PropertyAddress.StaircaseNumber
                        };
                        var propertyAddressId = await _propertyAddressRepository.AddAsync(propAddress, cancellationToken);
                        faFromDB.PropertyAddressId = propertyAddressId;
                    }
                }
                //nowy PropertyAddress == null
                else
                {
                    //stary PropertyAddress != null
                    if (faFromDB.PropertyAddress != null)
                    {
                        await _propertyAddressRepository.DeleteAsync(faFromDB.PropertyAddressId.Value, cancellationToken);
                    }
                    // stary PropertyAddress == null
                    else
                    {
                        
                    }

                }

                await _fullAddressRepository.UpdateAsync(faFromDB, cancellationToken);
            }
            await _propertyManagerRepository.UpdateAsync(pmFromDb, cancellationToken);


            return Unit.Value;
        }
    }
}
