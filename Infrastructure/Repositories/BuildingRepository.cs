                using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly ProwitechDbContext _dbContext;

        public BuildingRepository(ProwitechDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> AddAsync(Building building, CancellationToken cancellationToken)
        {
            if (await _dbContext.Buildings.AnyAsync(b => b.BuildingAddressId == building.BuildingAddressId))
                throw new Exception($"Istnieje już budynek mający adres o Id: {building.BuildingAddressId}");

            await _dbContext.AddAsync(building, cancellationToken);
            await _dbContext.SaveChangesAsync();
            return building.Id;
        }
        public async Task<IEnumerable<Building>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Buildings.
                Include(b => b.BuildingAddress).
                Include(b => b.PropertyManager).
                    ThenInclude(pm => pm.FullAddress).ThenInclude(fa=>fa.BuildingAddress).
                        ToArrayAsync(cancellationToken);
        }

        public async Task<Building> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.Buildings.
                Include(b => b.BuildingAddress).
                Include(b => b.PropertyManager).
                    ThenInclude(pm => pm.FullAddress).
                        FirstOrDefaultAsync(b => b.Id == id);
        }
        public async Task UpdateBuildingAsync(Building building, CancellationToken cancellationToken)
        {
            _dbContext.Entry(building).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            Building? buildingToDelete = await _dbContext.Buildings.FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
            if (buildingToDelete == null)
                throw new Exception($"Brak Budynku o identyfikatorze {id}.");
            Guid? buildingAddressIdToDelete = buildingToDelete.BuildingAddressId;
            if (buildingAddressIdToDelete != null)
            {
                BuildingAddress? buildingAddressToDelete=await _dbContext.BuildingAddresses.
                    FirstOrDefaultAsync(b => b.Id == buildingAddressIdToDelete, cancellationToken);
                if(buildingAddressToDelete != null)
                    _dbContext.BuildingAddresses.Remove(buildingAddressToDelete);
            }
            if (buildingToDelete == null)
                throw new Exception($"Brak Budynku o identyfikatorze {id}.");
            _dbContext.Buildings.Remove(buildingToDelete);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
