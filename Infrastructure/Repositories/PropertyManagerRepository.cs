﻿using Infrastructure.Database;
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
            await _dbContext.AddAsync(propMan, cancellationToken);
            return propMan.Id;

        }

        public async Task<IEnumerable<PropertyManager>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.PropertyManagers
                .Include(pm=>pm.FullAddress)
                    .ThenInclude(fa=>fa.BuildingAddress)
                .Include(pm=>pm.FullAddress)
                    .ThenInclude(fa => fa.PropertyAddress)
                .ToArrayAsync(cancellationToken);
        }

        public async Task<PropertyManager?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.PropertyManagers
                .Include(pm => pm.FullAddress)
                    .ThenInclude(fa => fa.BuildingAddress)
                .Include(pm => pm.FullAddress)
                    .ThenInclude(fa => fa.PropertyAddress)
                .FirstOrDefaultAsync(pm => pm.Id == id, cancellationToken);
        }

        public async Task UpdateAsync(PropertyManager propMan, CancellationToken cancellationToken)
        {
            _dbContext.Entry(propMan).State = EntityState.Modified;
        }
        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            PropertyManager? propMan = await _dbContext.PropertyManagers.FirstOrDefaultAsync(pm => pm.Id == id, cancellationToken);
            if(propMan == null)
                throw new Exception($"Brak Zarządcy Nieruchomości o identyfikatorze {id}.");
            
            _dbContext.PropertyManagers.Remove(propMan);
        }
    }
}
