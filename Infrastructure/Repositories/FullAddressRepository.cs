using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class FullAddressRepository : IFullAddressRepository
    {
        private readonly ProwitechDbContext _dbContext;
        public FullAddressRepository(ProwitechDbContext prowitechDbContext)
        {
            this._dbContext = prowitechDbContext;
        }
        public async Task<Guid> AddAsync(FullAddress fullAddress, CancellationToken cancellationToken)
        {

            if (fullAddress.PropertyAddress != null)
            {
                FullAddress? addressFound = await FindFullAddressWithPropertyAddress(fullAddress, cancellationToken);
                if (addressFound != null) throw new Exception($"Dodawany pełny adres już istnieje w bazie danych!");
            }
            else
            {
                FullAddress? addressFound = await FindFullAddressWithoutPropertyAddress(fullAddress, cancellationToken);
                if (addressFound != null) throw new Exception($"Dodawany pełny adres już istnieje w bazie danych!");
            }

            //if (await _dbContext.FullAddresses.AnyAsync(fa =>fullAddress.Equals(fa)))
            //    throw new Exception($"Dodawany pełny adres już istnieje w bazie danych!");
            //fa.BuildingAddressId == fullAddress.BuildingAddressId && fa.PropertyAddress!=null
            //&& fa.PropertyAddress.VenueNumber.ToUpper() == fullAddress.PropertyAddress.VenueNumber.ToUpper()
            //&& fa.PropertyAddress.StaircaseNumber.ToUpper() == fullAddress.PropertyAddress.StaircaseNumber.ToUpper()))
            //    throw new Exception($"Dodawany pełny adres już istnieje w bazie danych!");

            await _dbContext.AddAsync(fullAddress);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return fullAddress.Id;
        }

        public async Task<IEnumerable<FullAddress>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.FullAddresses
                .Include(fa => fa.BuildingAddress)
                .Include(fa => fa.PropertyAddress).ThenInclude(pa => pa.VenueNumber)
                .Include(fa => fa.PropertyAddress).ThenInclude(pa => pa.StaircaseNumber)
                .ToArrayAsync(cancellationToken);
        }

        public async Task<FullAddress?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.FullAddresses
                .Include(fa=>fa.BuildingAddress)
                .Include(fa=>fa.PropertyAddress).ThenInclude(pa=>pa.VenueNumber)
                .Include(fa => fa.PropertyAddress).ThenInclude(pa => pa.StaircaseNumber)
                .FirstOrDefaultAsync(fa => fa.Id == id, cancellationToken);
        }

        public async Task UpdateAsync(FullAddress address, CancellationToken cancellationToken)
        {
            _dbContext.Entry(address).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            
            FullAddress? fullAddress = await _dbContext.FullAddresses.
                FirstOrDefaultAsync(fa => fa.Id == id, cancellationToken);
            if (fullAddress == null)
                throw new Exception($"Brak Adresu o identyfikatorze {id}");
            _dbContext.FullAddresses.Remove(fullAddress);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
        public async Task<FullAddress?> FindFullAddressWithPropertyAddress(FullAddress address, CancellationToken cancellationToken)
        {
            FullAddress? faFromDB = await _dbContext.FullAddresses
                .FirstOrDefaultAsync(
                fa => fa.BuildingAddressId==address.BuildingAddressId && fa.PropertyAddress!=null
                && fa.PropertyAddress.VenueNumber==address.PropertyAddress.VenueNumber
                && fa.PropertyAddress.StaircaseNumber==address.PropertyAddress.StaircaseNumber, cancellationToken);
            return faFromDB;
        }
        public async Task<FullAddress?> FindFullAddressWithoutPropertyAddress(FullAddress address, CancellationToken cancellationToken)
        {
            FullAddress? faFromDB = await _dbContext.FullAddresses
                .FirstOrDefaultAsync(fa => fa.BuildingAddressId == address.BuildingAddressId);
            return faFromDB;
        }
    }
}
