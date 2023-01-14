                using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
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
        public async Task<Guid> AddAsync(Building building, Guid buildingAddressId, CancellationToken cancellationToken)
        {
            if (await _dbContext.Buildings.AnyAsync(b => b.BuildingAddressId == building.BuildingAddressId))
                throw new Exception($"Istnieje już budynek mający adres o Id: {building.BuildingAddressId}");

            if(building.Type!=BuildingType.WIELOLOKALOWY.ToString() && building.Type!=BuildingType.JEDNOLOKALOWY.ToString())
                throw new Exception($"Próba dodania niedozwolonego typu budynku: {building.Type}");

            var buildingAddressAssociatedWithNewBuilding = await _dbContext.BuildingAddresses
                .FirstOrDefaultAsync(ba => ba.Id == buildingAddressId);
            if (buildingAddressAssociatedWithNewBuilding != null)
            {
                var buildingWithTheSameBuildingAddressData = await _dbContext.Buildings.Where(
                b => b.BuildingAddress.CityName == buildingAddressAssociatedWithNewBuilding.CityName
                && b.BuildingAddress.StreetName == buildingAddressAssociatedWithNewBuilding.StreetName
                && b.BuildingAddress.BuildingNumber == buildingAddressAssociatedWithNewBuilding.BuildingNumber
                ).FirstOrDefaultAsync();
                if (buildingWithTheSameBuildingAddressData != null) throw new Exception($"Istnieje już budynek o takim adresie");
            }
            

            await _dbContext.AddAsync(building, cancellationToken);
            return building.Id;
        }
        public async Task<IEnumerable<Building>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Buildings.
                Include(b => b.BuildingAddress).
                Include(b => b.PropertyManager).
                    ThenInclude(pm => pm.FullAddress).
                    ThenInclude(fa => fa.BuildingAddress).
                Include(b => b.PropertyManager).
                    ThenInclude(pm => pm.FullAddress).
                    ThenInclude(fa => fa.PropertyAddress).
                        ToArrayAsync(cancellationToken);
        }

        public async Task<Building> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.Buildings.
                Include(b => b.BuildingAddress).
                Include(b => b.PropertyManager).
                    ThenInclude(pm => pm.FullAddress).
                ThenInclude(fa => fa.BuildingAddress).
            Include(b => b.PropertyManager).
                ThenInclude(pm => pm.FullAddress).
                ThenInclude(fa => fa.PropertyAddress).
            Include(b => b.Properties).
                ThenInclude(p => p.PropertyAddress).
            FirstOrDefaultAsync(b => b.Id == id);
        }
        public async Task UpdateBuildingAsync(Building building, CancellationToken cancellationToken)
        {
            _dbContext.Entry(building).State = EntityState.Modified;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            Building? buildingToDelete = await _dbContext.Buildings.FirstOrDefaultAsync(b => b.Id == id, cancellationToken);
            if (buildingToDelete == null)
                throw new Exception($"Brak Budynku o identyfikatorze {id}.");
            
            
            //TODO sprawdz czy lokale budynku mają przypisane protokoły - jeśli TAK, nie wolno usuwać Building
            //if(buildingToDelete.Properties!=null && buildingToDelete.Properties.Count > 0 && buildingToDelete.Properties.InspectionProtocols!=null)
            //{

            //}
            //TODO sprawdź czy przy usuwaniu WIELOLOKALOWY usuwają się Properties oraz PropertiesAddresses

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

            var buildingProperties = await _dbContext.RealProperties.Where(p => p.BuildingId == id).ToArrayAsync(cancellationToken);
            foreach(var property in buildingProperties)
            {
                var propAddress = await _dbContext.PropertyAddresses.FirstOrDefaultAsync(pa => pa.Id == property.PropertyAddressId, cancellationToken);

                if (propAddress != null) _dbContext.PropertyAddresses.Remove(propAddress);
            }
            
            _dbContext.Buildings.Remove(buildingToDelete);
        }
    }
}
