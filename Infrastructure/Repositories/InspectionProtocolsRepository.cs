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
    public class InspectionProtocolsRepository : IInspectionProtocolsRepository
    {
        private readonly ProwitechDbContext _dbContext;

        public InspectionProtocolsRepository(ProwitechDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> AddAsync(InspectionProtocol inspectionProtocol, CancellationToken cancellationToken)
        {
            if (await _dbContext.InspectionProtocols.AnyAsync(p => p.Number == inspectionProtocol.Number))
                throw new Exception($"Nie można dodać protokołu przeglądu: Numer protokołu musi być oryginalny");
            
            if(inspectionProtocol.InspectionTaskId != null)
            {
                if (await _dbContext.InspectionProtocols.AnyAsync
                (p => p.InspectedPropertyId == inspectionProtocol.InspectedPropertyId
                && p.InspectionTaskId == inspectionProtocol.InspectionTaskId))
                    throw new Exception
                        ($"Nie można dodać protokołu przeglądu: Istnieje już protokół Nieruchomości od ID: {inspectionProtocol.InspectedPropertyId} przypisany do zadania od ID: {inspectionProtocol.InspectionTaskId}");
            }
            await _dbContext.AddAsync(inspectionProtocol, cancellationToken);
            return inspectionProtocol.Id;

        }

        public async Task UpdateAsync(InspectionProtocol inspectionProtocol, CancellationToken cancellationToken)
        {
            if (await _dbContext.InspectionProtocols.AnyAsync(p => p.Id != inspectionProtocol.Id && p.Number == inspectionProtocol.Number))
                throw new Exception($"Nie można dodać protokołu przeglądu: Numer protokołu musi być oryginalny");

            if (inspectionProtocol.InspectionTaskId != null)
            {
                if (await _dbContext.InspectionProtocols.AnyAsync
                (p => p.Id!=inspectionProtocol.Id && p.InspectedPropertyId == inspectionProtocol.InspectedPropertyId
                && p.InspectionTaskId == inspectionProtocol.InspectionTaskId))
                    throw new Exception
                        ($"Nie można dodać protokołu przeglądu: Istnieje już protokół Nieruchomości od ID: {inspectionProtocol.InspectedPropertyId} przypisany do zadania od ID: {inspectionProtocol.InspectionTaskId}");
            }
            _dbContext.Entry(inspectionProtocol).State = EntityState.Modified;
        }

        public async Task<IEnumerable<InspectionProtocol>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionProtocols.
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.Building).
                        ThenInclude(b => b.BuildingAddress).
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.PropertyAddress).
                    ToArrayAsync(cancellationToken);
        }

        public async Task<InspectionProtocol> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionProtocols.
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.Building).
                        ThenInclude(b => b.BuildingAddress).
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.PropertyAddress).
                    FirstOrDefaultAsync(ip=>ip.Id == id, cancellationToken);
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            InspectionProtocol? protocolToDelete = await _dbContext.InspectionProtocols.FirstOrDefaultAsync(ip => ip.Id == id, cancellationToken);
            if (protocolToDelete == null)
                throw new Exception($"Nie można usunąć Protokołu Inspekcji: Brak Protokołu o ID: {id}");
            _dbContext.InspectionProtocols.Remove(protocolToDelete);
        }
        public async Task<IEnumerable<InspectionProtocol>> GetInspectionProtocolsOfParticularPerformer(Guid userId, CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionProtocols.
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.Building).
                        ThenInclude(b => b.BuildingAddress).
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.PropertyAddress).
                    Where(ip => ip.InspectionPerformerId == userId).ToArrayAsync(cancellationToken);
        }

        public async Task<IEnumerable<InspectionProtocol>> GetInspectionProtocolsOfParticularTask(Guid inspectionTaskId, CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionProtocols.
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.Building).
                        ThenInclude(b => b.BuildingAddress).
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.PropertyAddress).
                    Where(ip => ip.InspectionTaskId == inspectionTaskId).ToArrayAsync(cancellationToken);
        }


    }
}
