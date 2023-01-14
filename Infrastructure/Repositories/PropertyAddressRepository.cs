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
    public class PropertyAddressRepository : IPropertyAddressRepository
    {
        private readonly ProwitechDbContext _dbContext;
        public PropertyAddressRepository(ProwitechDbContext prowitechDbContext)
        {
            this._dbContext = prowitechDbContext;
        }
        public async Task<Guid> AddAsync(PropertyAddress propAddress, CancellationToken cancellationToken)
        {
            //TODO SPRAWDZIC CZY NIE TRZEBA CZEGOS SPRAWDZIC
            await _dbContext.AddAsync(propAddress);
            return propAddress.Id;
        }

        public async Task<IEnumerable<PropertyAddress>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.PropertyAddresses.ToArrayAsync(cancellationToken);
        }

        public async Task<PropertyAddress?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.PropertyAddresses.FirstOrDefaultAsync(pa => pa.Id == id, cancellationToken);
        }

        public async Task UpdateAsync(PropertyAddress propAddress, CancellationToken cancellationToken)
        {
            _dbContext.Entry(propAddress).State = EntityState.Modified;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {

            PropertyAddress? propAddress = await _dbContext.PropertyAddresses.
                FirstOrDefaultAsync(fa => fa.Id == id, cancellationToken);
            if (propAddress == null)
                throw new Exception($"Brak Adresu Nieruchomości o identyfikatorze {id}");
            _dbContext.PropertyAddresses.Remove(propAddress);
        }
    }
}
