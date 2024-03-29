﻿using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
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

        public async Task<bool> CheckIfRealPropertyAlreadyExists(RealProperty property, bool creationMode, CancellationToken cancellationToken)
        {
            if (creationMode)
            {
                if (await _dbContext.RealProperties
                .AnyAsync(p => p.BuildingId == property.BuildingId
                && p.PropertyAddress.VenueNumber == property.PropertyAddress!.VenueNumber
                && p.PropertyAddress.StaircaseNumber == property.PropertyAddress.StaircaseNumber, cancellationToken))
                {
                    return true;
                }
            }
            else
            {
                if (await _dbContext.RealProperties
                .AnyAsync(p => p.Id!= property.Id && p.BuildingId == property.BuildingId
                && p.PropertyAddress.VenueNumber == property.PropertyAddress!.VenueNumber
                && p.PropertyAddress.StaircaseNumber == property.PropertyAddress.StaircaseNumber, cancellationToken))
                {
                    return true;
                }
            }
            return false;


        }

        public async Task<Guid> AddAsync(RealProperty property, CancellationToken cancellationToken)
        {
            var building = await _dbContext.Buildings.FirstOrDefaultAsync(b => b.Id == property.BuildingId);
            var buildingType = building!.Type;

            if(building.Type==BuildingType.JEDNOLOKALOWY.ToString() && building.Properties!= null && building.Properties.Count == 1)
            {
                throw new Exception($"Nie można dodać nieruchomości: Budynek posiada już jedną nieruchomość, a jest JEDNOLOKALOWY");
            }
                
            await _dbContext.AddAsync(property, cancellationToken);
            return property.Id;
        }


        //public async Task<IEnumerable<RealProperty>> GetAllPropertiesOfBuilding(Guid buildingId, CancellationToken cancellationToken)
        //{
        //    return await _dbContext.RealProperties
        //        .Where(p=>p.BuildingId==buildingId)
        //        .Include(p=>p.PropertyAddress)
        //        .ToArrayAsync(cancellationToken);
        //}

        public async Task<IEnumerable<RealProperty>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.RealProperties.
                Include(rp => rp.PropertyAddress).
                Include(rp => rp.Building).
                    ThenInclude(b => b.BuildingAddress).
                Include(rp => rp.Building).
                    ThenInclude(b => b.PropertyManager).
                    ToArrayAsync(cancellationToken);
        }

        public async Task<RealProperty?> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            var realProp = await _dbContext.RealProperties.
                Include(rp=>rp.PropertyAddress).
                Include(rp=>rp.Building).
                    ThenInclude(b=>b.BuildingAddress).
                Include(rp=>rp.Building).
                    ThenInclude(b=>b.PropertyManager).
                        ThenInclude(pm=>pm.FullAddress).
                        ThenInclude(fa=>fa.BuildingAddress).
                Include(rp => rp.Building).
                    ThenInclude(b => b.PropertyManager).
                        ThenInclude(pm => pm.FullAddress).
                        ThenInclude(fa => fa.PropertyAddress).
                FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
            if (realProp == null)
                throw new Exception($"W bazie danych nie znaleziono Nieruchomości o ID: {id}");
            return realProp;
        }

        public async Task UpdateAsync(RealProperty property, CancellationToken cancellationToken)
        {
            _dbContext.Entry(property).State = EntityState.Modified;
        }
        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var property = await _dbContext.RealProperties.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
            if(property==null)
                throw new Exception($"Brak Nieruchomości o identyfikatorze {id}.");
            if (property.PropertyAddressId != null)
            {
                var propAddress = await _dbContext.PropertyAddresses.FirstOrDefaultAsync(a=>a.Id==property.PropertyAddressId, cancellationToken);
                _dbContext.PropertyAddresses.Remove(propAddress!);
            }
            _dbContext.RealProperties.Remove(property);
        }

        public async Task<RealProperty?> GetOnePropertyOfParticularBuilding(Guid buildingId, CancellationToken cancellationToken)
        {
            return await _dbContext.RealProperties.FirstOrDefaultAsync(p => p.BuildingId== buildingId, cancellationToken);
        }
    }
}
