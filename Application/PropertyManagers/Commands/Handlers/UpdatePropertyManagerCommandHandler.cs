using Application.PropertyManagers.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
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
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public UpdatePropertyManagerCommandHandler(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdatePropertyManagerCommand command, CancellationToken cancellationToken)
        {
            var pmFromDb = await _unitOfWork.PropertyManagerRepository.GetAsync(command.Id, cancellationToken);
            if (pmFromDb == null)
                throw new Exception($"W bazie danych nie ma szukanego Zarządcy Nieruchomości, aby móc go edytować");

            pmFromDb.Name = command.Name;
            pmFromDb.PhoneNumber = command.PhoneNumber;

            if (command.UpdateFullAddressDTO != null && pmFromDb.FullAddressId != null)
            {
                FullAddress faFromDB = await _unitOfWork.FullAddressRepository.GetAsync(pmFromDb.FullAddressId.Value, cancellationToken);
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
                        var propertyAddressId = await _unitOfWork.PropertyAddressRepository.AddAsync(propAddress, cancellationToken);
                        await _unitOfWork.SaveChangesAsync(cancellationToken);
                        faFromDB.PropertyAddressId = propertyAddressId;
                    }
                }
                //nowy PropertyAddress == null
                else
                {
                    //stary PropertyAddress != null
                    if (faFromDB.PropertyAddress != null)
                    {
                        await _unitOfWork.PropertyAddressRepository.DeleteAsync(faFromDB.PropertyAddressId!.Value, cancellationToken);
                        await _unitOfWork.SaveChangesAsync(cancellationToken);
                    }
                    // stary PropertyAddress == null
                    else
                    {
                        
                    }

                }

                await _unitOfWork.FullAddressRepository.UpdateAsync(faFromDB, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
            await _unitOfWork.PropertyManagerRepository.UpdateAsync(pmFromDb, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
