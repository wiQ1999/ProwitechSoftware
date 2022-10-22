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
            //if (await _dbContext.FullAddresses.AnyAsync(fa => fa.Equals(fullAddress)))
            //    throw new Exception($"Dodawany pełny adres już istnieje w bazie danych!");
            if (await _dbContext.FullAddresses.AnyAsync(fa => fa.BuildingAddressId == fullAddress.BuildingAddressId && fa.LocalNumber==fullAddress.LocalNumber))
                throw new Exception($"Dodawany pełny adres już istnieje w bazie danych!");

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
            return await _dbContext.FullAddresses.Include(fa=>fa.BuildingAddress).FirstOrDefaultAsync(fa => fa.Id == id, cancellationToken);
        }

        public async Task UpdateAsync(FullAddress address, CancellationToken cancellationToken)
        {
            _dbContext.Entry(address).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
