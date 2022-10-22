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
    public class PropertyManagerRepository : IPropertyManagerRepository
    {
        private readonly ProwitechDbContext _dbContext;

        public PropertyManagerRepository(ProwitechDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> AddAsync(PropertyManager propMan, CancellationToken cancellationToken)
        {
            if (await _dbContext.PropertyManagers.AnyAsync(pm => pm.Name == propMan.Name))
                throw new Exception($"Istnieje już Zarządca Nieruchomości o nazwie {propMan.Name}");
            if (await _dbContext.PropertyManagers.AnyAsync(pm => pm.FullAddress.Equals(propMan.FullAddress)))
                throw new Exception($"Istnieje już Zarządca Nieruchomości o adresie {propMan.FullAddress.ToString()}");
            await _dbContext.AddAsync(propMan, cancellationToken);
            await _dbContext.SaveChangesAsync();
            return propMan.Id;

        }

        public Task<IEnumerable<PropertyManager>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<PropertyManager> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PropertyManager propMan, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
