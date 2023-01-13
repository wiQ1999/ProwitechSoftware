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
    public class RealPropertyRepository : IRealPropertyRepository
    {
        private readonly ProwitechDbContext _dbContext;

        public RealPropertyRepository(ProwitechDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> AddAsync(RealProperty property, CancellationToken cancellationToken)
        {
            if (await _dbContext.RealProperties
                .AnyAsync(p => p.BuildingId == property.BuildingId
                && p.PropertyAddress.VenueNumber == property.PropertyAddress.VenueNumber
                && p.PropertyAddress.StaircaseNumber == property.PropertyAddress.StaircaseNumber, cancellationToken))
            {
                _dbContext.PropertyAddresses.Remove(property.PropertyAddress);
                await _dbContext.SaveChangesAsync(cancellationToken);
                throw new Exception($"W bazie danych istnieje już podana Nieruchomość!");

            }
                
            await _dbContext.AddAsync(property, cancellationToken);
            await _dbContext.SaveChangesAsync();
            return property.Id;
        }


        public async Task<IEnumerable<RealProperty>> GetAllPropertiesOfBuilding(Guid buildingId, CancellationToken cancellationToken)
        {
            return await _dbContext.RealProperties
                .Where(p=>p.BuildingId==buildingId)
                .Include(p=>p.PropertyAddress)
                .ToArrayAsync(cancellationToken);
        }

        public async Task<IEnumerable<RealProperty>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.RealProperties.ToArrayAsync(cancellationToken);
        }

        public async Task<RealProperty?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.RealProperties.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
        }

        public async Task UpdateAsync(RealProperty property, CancellationToken cancellationToken)
        {
            _dbContext.Entry(property).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var property = await _dbContext.RealProperties.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
            if(property==null)
                throw new Exception($"Brak Nieruchomości o identyfikatorze {id}.");
            _dbContext.RealProperties.Remove(property);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<RealProperty?> GetOnePropertyOfParticularBuilding(Guid buildingId, CancellationToken cancellationToken)
        {
            return await _dbContext.RealProperties.FirstOrDefaultAsync(p => p.BuildingId== buildingId, cancellationToken);
        }
    }
}
