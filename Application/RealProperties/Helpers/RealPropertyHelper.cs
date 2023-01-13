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
    public class RealPropertyHelper
    {
        private readonly IRealPropertyRepository _propertyRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;

        public RealPropertyHelper(IRealPropertyRepository propertyRepository, IPropertyAddressRepository propertyAddressRepository)
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
                var propertyToDelete = await _propertyRepository.GetOnePropertyOfParticularBuilding(buildingFromDB.Id, cancellationToken);
                var propertyAddressToDeleteId = propertyToDelete?.PropertyAddressId;
                if (propertyAddressToDeleteId!=null)
                    await _propertyAddressRepository.DeleteAsync(propertyAddressToDeleteId.Value, cancellationToken);
            }
            else if (oldBuildingType == BuildingType.WIELOLOKALOWY.ToString()
                && newBuildingType == BuildingType.JEDNOLOKALOWY.ToString())
            {
                PropertyAddress propertyAddress = new PropertyAddress();
                var propertyAddressId = await _propertyAddressRepository.AddAsync(propertyAddress, cancellationToken);

                RealProperty property = new RealProperty()
                {
                    BuildingId = buildingFromDB.Id,
                    PropertyAddressId = propertyAddressId
                };
                await _propertyRepository.AddAsync(property, cancellationToken);
            }
        }
    }
}
