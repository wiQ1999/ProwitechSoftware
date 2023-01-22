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
    public class FullAddressRepository : IFullAddressRepository
    {
        private readonly ProwitechDbContext _dbContext;
        public FullAddressRepository(ProwitechDbContext prowitechDbContext)
        {
            this._dbContext = prowitechDbContext;
        }
        public async Task<Guid> AddAsync(FullAddress fullAddress, CancellationToken cancellationToken)
        {

            await _dbContext.AddAsync(fullAddress, cancellationToken);
            return fullAddress.Id;
        }

        public async Task<IEnumerable<FullAddress>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.FullAddresses
                .Include(fa => fa.BuildingAddress)
                .Include(fa => fa.PropertyAddress)
                .ToArrayAsync(cancellationToken);
        }

        public async Task<FullAddress?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.FullAddresses
                .Include(fa=>fa.BuildingAddress)
                .Include(fa=>fa.PropertyAddress)
                .FirstOrDefaultAsync(fa => fa.Id == id, cancellationToken);
        }

        public async Task UpdateAsync(FullAddress address, CancellationToken cancellationToken)
        {
            _dbContext.Entry(address).State = EntityState.Modified;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            
            FullAddress? fullAddress = await _dbContext.FullAddresses.
                FirstOrDefaultAsync(fa => fa.Id == id, cancellationToken);
            if (fullAddress == null)
                throw new Exception($"Brak Adresu o identyfikatorze {id}");
            if (fullAddress.PropertyAddress != null)
            {
                _dbContext.PropertyAddresses.Remove(fullAddress.PropertyAddress);
            }
            if (fullAddress.BuildingAddress != null)
            {
                _dbContext.BuildingAddresses.Remove(fullAddress.BuildingAddress);
            }
                
            _dbContext.FullAddresses.Remove(fullAddress);
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
