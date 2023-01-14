using Application.FullAddresses.DTOs;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.UnitOfWork;
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
        private readonly IRepositoriesUnitOfWork _unitOfWork;

        public FullAddressCRUDHelper(IRepositoriesUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
                var faFromDB = await _unitOfWork.FullAddressRepository.FindFullAddressWithPropertyAddress(fullAddress, cancellationToken);

                if (faFromDB == null)
                {
                    var propertyAddressId = await _unitOfWork.PropertyAddressRepository.AddAsync(propertyAddress, cancellationToken);
                    await _unitOfWork.SaveChangesAsync(cancellationToken);
                    fullAddress = new FullAddress()
                    {
                        BuildingAddressId = fullAddressDTO.BuildingAddressId,
                        PropertyAddressId = propertyAddressId
                    };
                    fullAddressId = await _unitOfWork.FullAddressRepository.AddAsync(fullAddress, cancellationToken);
                    await _unitOfWork.SaveChangesAsync(cancellationToken);

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
                var faFromDB = await _unitOfWork.FullAddressRepository.FindFullAddressWithoutPropertyAddress(fullAddress, cancellationToken);

                if (faFromDB == null)
                {
                    fullAddressId = await _unitOfWork.FullAddressRepository.AddAsync(fullAddress, cancellationToken);
                    await _unitOfWork.SaveChangesAsync(cancellationToken);
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
