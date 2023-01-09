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
    public class PropertyRepository : IPropertyRepository
    {
        private readonly ProwitechDbContext _dbContext;

        public PropertyRepository(ProwitechDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> AddAsync(Property property, CancellationToken cancellationToken)
        {
            await _dbContext.AddAsync(property, cancellationToken);
            await _dbContext.SaveChangesAsync();
            return property.Id;
        }


        public async Task<IEnumerable<Property>> GetAllPropertiesOfBuilding(Guid buildingId, CancellationToken cancellationToken)
        {
            return await _dbContext.Properties
                .Where(p=>p.BuildingId==buildingId)
                .Include(p=>p.PropertyAddress)
                .ToArrayAsync(cancellationToken);
        }

        public async Task<IEnumerable<Property>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Properties.ToArrayAsync(cancellationToken);
        }

        public async Task<Property?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.Properties.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
        }

        public async Task UpdateAsync(Property property, CancellationToken cancellationToken)
        {
            _dbContext.Entry(property).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var property = await _dbContext.Properties.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
            if(property==null)
                throw new Exception($"Brak Nieruchomości o identyfikatorze {id}.");
            _dbContext.Properties.Remove(property);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<Property?> GetOnePropertyOfParticularBuilding(Guid buildingId, CancellationToken cancellationToken)
        {
            return await _dbContext.Properties.FirstOrDefaultAsync(p => p.BuildingId== buildingId, cancellationToken);
        }
    }
}
