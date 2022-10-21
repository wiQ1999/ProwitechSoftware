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
            if (await _dbContext.FullAddresses.AnyAsync(
                fa=>fa.BuildingAddressId==fullAddress.BuildingAddressId && fa.LocalInfoId==fullAddress.LocalInfoId))
                throw new Exception($"Dodawany pełny adres już istnieje w bazie danych!");
            fullAddress.Id = Guid.NewGuid();
            await _dbContext.AddAsync(fullAddress);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return fullAddress.Id;
        }

        public async Task<IEnumerable<FullAddress>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.FullAddresses.ToArrayAsync(cancellationToken);
        }

        public async Task<FullAddress?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.FullAddresses.FirstOrDefaultAsync(fa => fa.Id == id, cancellationToken);
        }

        public Task UpdateAsync(FullAddress address, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
