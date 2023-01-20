using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Properties.Helpers
{
    public class RealPropertyHelper
    {
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public RealPropertyHelper(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddOrRemovePropertyBasedOnBuildingType(Building buildingFromDB, string newBuildingType, CancellationToken cancellationToken)
        {
            string oldBuildingType = buildingFromDB.Type;

            if (oldBuildingType == BuildingType.JEDNOLOKALOWY.ToString()
                && newBuildingType == BuildingType.WIELOLOKALOWY.ToString())
            {
                var propertyToDelete = await _unitOfWork.RealPropertyRepository.GetOnePropertyOfParticularBuilding(buildingFromDB.Id, cancellationToken);
                var propertyAddressToDeleteId = propertyToDelete?.PropertyAddressId;
                if (propertyAddressToDeleteId != null)
                {
                    await _unitOfWork.PropertyAddressRepository.DeleteAsync(propertyAddressToDeleteId.Value, cancellationToken);
                    await _unitOfWork.SaveChangesAsync(cancellationToken);

                }

            }
            else if (oldBuildingType == BuildingType.WIELOLOKALOWY.ToString()
                && newBuildingType == BuildingType.JEDNOLOKALOWY.ToString())
            {
                PropertyAddress propertyAddress = new PropertyAddress();
                var propertyAddressId = await _unitOfWork.PropertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                RealProperty property = new RealProperty()
                {
                    BuildingId = buildingFromDB.Id,
                    PropertyAddressId = propertyAddressId,
                    PropertyAddress = propertyAddress
                };
                await _unitOfWork.RealPropertyRepository.AddAsync(property, cancellationToken);
                await _unitOfWork.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task CheckIfRealPropertyAlreadyExists(RealProperty property, bool creationMode, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.RealPropertyRepository.CheckIfRealPropertyAlreadyExists(property, creationMode, cancellationToken))
            {
                if (creationMode)
                {
                    await _unitOfWork.PropertyAddressRepository.DeleteAsync(property.PropertyAddressId.Value, cancellationToken);
                    await _unitOfWork.SaveChangesAsync(cancellationToken);

                }
                throw new Exception($"W bazie danych istnieje już podana Nieruchomość!");
            }

        }

    }
}
