using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Properties.Helpers
{
    public class PropertyChanger
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;

        public PropertyChanger(IPropertyRepository propertyRepository, IPropertyAddressRepository propertyAddressRepository)
        {
            _propertyRepository = propertyRepository;
            _propertyAddressRepository = propertyAddressRepository;
        }
        public async Task AddOrRemovePropertyBasedOnBuildingType(Building buildingFromDB, string newBuildingType, CancellationToken cancellationToken)
        {
            string oldBuildingType = buildingFromDB.Type;

            if (oldBuildingType==BuildingType.JEDNOLOKALOWY.ToString()
                && newBuildingType == BuildingType.WIELOLOKALOWY.ToString())
            {
                var propertyToDelete = await _propertyRepository.GetPropertyOfParticularBuilding(buildingFromDB.Id, cancellationToken);
                var propertyAddressToDeleteId = propertyToDelete?.PropertyAddressId;
                if (propertyAddressToDeleteId!=null)
                    await _propertyAddressRepository.DeleteAsync(propertyAddressToDeleteId.Value, cancellationToken);
                if (propertyToDelete != null)
                    await _propertyRepository.DeleteAsync(propertyToDelete.Id, cancellationToken);
            }
            else if (oldBuildingType == BuildingType.WIELOLOKALOWY.ToString()
                && newBuildingType == BuildingType.JEDNOLOKALOWY.ToString())
            {
                PropertyAddress propertyAddress = new PropertyAddress();
                var propertyAddressId = await _propertyAddressRepository.AddAsync(propertyAddress, cancellationToken);

                Property property = new Property()
                {
                    BuildingId = buildingFromDB.Id,
                    PropertyAddressId = propertyAddressId
                };
                await _propertyRepository.AddAsync(property, cancellationToken);
            }
        }
    }
}
