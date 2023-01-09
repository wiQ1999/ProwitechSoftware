using Application.FullAddresses.DTOs;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FullAddresses.HelperMethods
{
    public class FullAddressCRUDHelper
    {
        private readonly IFullAddressRepository _fullAddressRepository;
        private readonly IPropertyAddressRepository _propertyAddressRepository;

        public FullAddressCRUDHelper(IFullAddressRepository fullAddressRepository, IPropertyAddressRepository propertyAddressRepository)
        {
            _fullAddressRepository = fullAddressRepository;
            _propertyAddressRepository = propertyAddressRepository;
        }

        public async Task<Guid> GetCreatedOrAlreadyExistingFullAddressId(FullAddressDTO fullAddressDTO, CancellationToken cancellationToken)
        {

            Guid fullAddressId;
            FullAddress fullAddress;
            if (fullAddressDTO.PropertyAddressDTO != null)
            {
                var propertyAddress = new PropertyAddress()
                {
                    VenueNumber = fullAddressDTO.PropertyAddressDTO.VenueNumber,
                    StaircaseNumber = fullAddressDTO.PropertyAddressDTO.StaircaseNumber
                };
                fullAddress = new FullAddress()
                {
                    BuildingAddressId = fullAddressDTO.BuildingAddressId,
                    PropertyAddress = propertyAddress
                };
                var faFromDB = await _fullAddressRepository.FindFullAddressWithPropertyAddress(fullAddress, cancellationToken);

                if (faFromDB == null)
                {
                    var propertyAddressId = await _propertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
                    fullAddress = new FullAddress()
                    {
                        BuildingAddressId = fullAddressDTO.BuildingAddressId,
                        PropertyAddressId = propertyAddressId
                    };
                    fullAddressId = await _fullAddressRepository.AddAsync(fullAddress, cancellationToken);
                }
                else
                {
                    fullAddressId = faFromDB.Id;
                }
            }
            else
            {
                fullAddress = new FullAddress()
                {
                    BuildingAddressId = fullAddressDTO.BuildingAddressId,
                };
                var faFromDB = await _fullAddressRepository.FindFullAddressWithoutPropertyAddress(fullAddress, cancellationToken);

                if (faFromDB == null)
                {
                    fullAddressId = await _fullAddressRepository.AddAsync(fullAddress, cancellationToken);
                }
                else
                {
                    fullAddressId = faFromDB.Id;
                }

            }
            return fullAddressId;
        }
    }
}
