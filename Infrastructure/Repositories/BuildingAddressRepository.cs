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
    public class BuildingAddressRepository : IBuildingAddressRepository
    {
        private readonly ProwitechDbContext _dbContext;
        public BuildingAddressRepository(ProwitechDbContext prowitechDbContext)
        {
            this._dbContext = prowitechDbContext;
        }
        public async Task<IEnumerable<BuildingAddress>> GetAllAsync(CancellationToken cancellationToken) =>
            await _dbContext.BuildingAddresses.ToArrayAsync(cancellationToken);

        public async Task<BuildingAddress?> GetAsync(Guid id, CancellationToken cancellationToken) =>
            await _dbContext.BuildingAddresses.FirstOrDefaultAsync(b => b.Id == id, cancellationToken);

        public async Task<BuildingAddress> AddAsync(BuildingAddress address, CancellationToken cancellationToken)
        {
            if (await _dbContext.BuildingAddresses.AnyAsync(
                b => b.CityName == address.CityName && b.StreetName == address.StreetName && b.BuildingNumber == address.BuildingNumber
                ))
                throw new Exception($"Dodawany adres już istnieje w bazie danych!");
            address.Id = Guid.NewGuid();
            await _dbContext.AddAsync(address);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return address;
        }
        public async Task UpdateBuildingAddressAsync(BuildingAddress address, CancellationToken cancellationToken)
        {
            _dbContext.Entry(address).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            BuildingAddress? baFromDB = await _dbContext.BuildingAddresses.FirstOrDefaultAsync(ba => ba.Id == id, cancellationToken);
            if (baFromDB == null)
                throw new Exception($"Brak Adresu Budynku o identyfikatorze {id}.");
            _dbContext.BuildingAddresses.Remove(baFromDB);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

    }
}
