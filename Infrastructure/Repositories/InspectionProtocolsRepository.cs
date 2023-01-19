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
            {
                //PRZED WYRZUCENIEM WYJĄTKU, USUŃ RESIDENTA PRZYPISANEGO DO PROTOKOŁU, JEŻELI NIE JEST PRZYPISANY
                //DO ŻADNEGO INNEGO PROTOKOŁU
                
                if (!await _dbContext.InspectionProtocols.AnyAsync(ip => ip.ResidentId == inspectionProtocol.ResidentId,cancellationToken))
                {
                    var residentToDelete = await _dbContext.Residents.FirstOrDefaultAsync(r => r.Id == inspectionProtocol.ResidentId);
                    _dbContext.Remove(residentToDelete!);
                    await _dbContext.SaveChangesAsync(cancellationToken);
                }
               throw new Exception($"Nie można dodać protokołu przeglądu: Numer protokołu musi być oryginalny");
            }

            if (inspectionProtocol.InspectionTaskId != null)
            {
                if (await _dbContext.InspectionProtocols.AnyAsync
                (p => p.InspectedPropertyId == inspectionProtocol.InspectedPropertyId
                && p.InspectionTaskId == inspectionProtocol.InspectionTaskId))
                {
                    //PRZED WYRZUCENIEM WYJĄTKU, USUŃ RESIDENTA PRZYPISANEGO DO PROTOKOŁU, JEŻELI NIE JEST PRZYPISANY
                    //DO ŻADNEGO INNEGO PROTOKOŁU
                    if (!await _dbContext.InspectionProtocols.AnyAsync(ip => ip.ResidentId == inspectionProtocol.ResidentId))
                    {
                        var residentToDelete = await _dbContext.Residents.FirstOrDefaultAsync(r => r.Id == inspectionProtocol.ResidentId);
                        _dbContext.Remove(residentToDelete!);
                        await _dbContext.SaveChangesAsync(cancellationToken);
                    }
                    throw new Exception
                        ($"Nie można dodać protokołu przeglądu: Istnieje już protokół Nieruchomości o ID:" +
                        $"{inspectionProtocol.InspectedPropertyId} przypisany do" +
                        $"zadania od ID: {inspectionProtocol.InspectionTaskId}");
                }
                    
            }
            await _dbContext.AddAsync(inspectionProtocol, cancellationToken);
            return inspectionProtocol.Id;

        }

        public async Task UpdateAsync(InspectionProtocol inspectionProtocol, Guid oldResidentId, CancellationToken cancellationToken)
        {
            if (await _dbContext.InspectionProtocols.AnyAsync(p => p.Id != inspectionProtocol.Id && p.Number == inspectionProtocol.Number))
            {
                //PRZED WYRZUCENIEM WYJĄTKU, USUŃ RESIDENTA, JEŻELI ZOSTAŁ STWORZONY LUB POBRANY PRZY UPDACIE, JEŻELI NIE
                //MA PROTOKOŁÓW PRZYPISANYCH DO NIEGO
                if (inspectionProtocol.ResidentId != oldResidentId)
                {
                    if (!await _dbContext.InspectionProtocols.AnyAsync(ip => ip.ResidentId == inspectionProtocol.ResidentId))
                    {
                        var residentToDelete = await _dbContext.Residents.FirstOrDefaultAsync(r => r.Id == inspectionProtocol.ResidentId);
                        _dbContext.Remove(residentToDelete!);
                        await _dbContext.SaveChangesAsync(cancellationToken);
                    }
                }
                
                throw new Exception($"Nie można edytować protokołu przeglądu: Numer protokołu musi być oryginalny");
            }

            if (inspectionProtocol.InspectionTaskId != null)
            {
                if (await _dbContext.InspectionProtocols.AnyAsync
                (p => p.Id!=inspectionProtocol.Id && p.InspectedPropertyId == inspectionProtocol.InspectedPropertyId
                && p.InspectionTaskId == inspectionProtocol.InspectionTaskId))
                {
                    //PRZED WYRZUCENIEM WYJĄTKU, USUŃ RESIDENTA, JEŻELI ZOSTAŁ STWORZONY LUB POBRANY PRZY UPDACIE, JEŻELI NIE
                    //MA PROTOKOŁÓW PRZYPISANYCH DO NIEGO
                    if (inspectionProtocol.ResidentId != oldResidentId)
                    {
                        if (!await _dbContext.InspectionProtocols.AnyAsync(ip => ip.ResidentId == inspectionProtocol.ResidentId))
                        {
                            var residentToDelete = await _dbContext.Residents.FirstOrDefaultAsync(r => r.Id == inspectionProtocol.ResidentId);
                            _dbContext.Remove(residentToDelete!);
                            await _dbContext.SaveChangesAsync(cancellationToken);
                        }
                        
                    }
                    throw new Exception
                            ($"Nie można edytować protokołu przeglądu: Istnieje już " +
                            $"protokół Nieruchomości o ID: {inspectionProtocol.InspectedPropertyId} " +
                            $"przypisany do zadania od ID: {inspectionProtocol.InspectionTaskId}");

                }
                    
            }
            _dbContext.Entry(inspectionProtocol).State = EntityState.Modified;
        }

        public async Task<IEnumerable<InspectionProtocol>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionProtocols.
                Include(ip => ip.InspectionPerformer).
                Include(ip => ip.Resident).
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
                Include(ip=>ip.InspectionPerformer).
                Include(ip=>ip.InspectionTask).
                    ThenInclude(t=>t.TaskDelegator).
                Include(ip => ip.InspectionTask).
                    ThenInclude(t => t.TaskPerformer).
                Include(ip => ip.InspectionTask).
                    ThenInclude(t => t.Building).
                        ThenInclude(b=>b.BuildingAddress).
                Include(ip=>ip.Resident).
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
                Include(ip => ip.InspectionPerformer).
                Include(ip => ip.Resident).
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
                Include(ip => ip.InspectionPerformer).
                Include(ip => ip.Resident).
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.Building).
                        ThenInclude(b => b.BuildingAddress).
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.PropertyAddress).
                    Where(ip => ip.InspectionTaskId == inspectionTaskId).ToArrayAsync(cancellationToken);
        }
        public async Task<string> GetTheBiggestProtocolNumber(string today, CancellationToken cancellation)
        {
            var simmilarProtocols = await _dbContext.InspectionProtocols.Where(p => p.Number.StartsWith(today)).ToArrayAsync(cancellation);
            if (simmilarProtocols == null)
                return String.Concat(today, "_P01");
            uint number = 0;
            foreach(var protocol in simmilarProtocols)
            {
                int PsymbolIndex = protocol.Number.IndexOf("P");
                uint numberFound = UInt32.Parse(protocol.Number.Substring(PsymbolIndex));
                if (numberFound > number)
                    number = numberFound;
            }
            string createdNumber;
            if (number < 10)
                createdNumber = number.ToString().PadLeft(2, '0');
            else
                createdNumber = number.ToString();
            return String.Concat(today + "_P" + createdNumber);
        }
        public async Task CheckIfInspectionProtocolWithThisNumberExists(Guid oldProtocolId, string newNumber, CancellationToken cancellation)
        {
            if (await _dbContext.InspectionProtocols.AnyAsync(ip => ip.Id != oldProtocolId && ip.Number == newNumber))
                throw new Exception($"Nie można edytować Protokołu - Protokół o numerze {newNumber} już istnieje");
        }
        public async Task<IEnumerable<InspectionProtocol>> GetProtocolsOfParticularBuilding(Guid buildingId, CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionProtocols.
                Include(ip => ip.InspectionPerformer).
                Include(ip => ip.Resident).
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.Building).
                        ThenInclude(b => b.BuildingAddress).
                Include(ip => ip.InspectedProperty).
                    ThenInclude(p => p.PropertyAddress).
                Where(ip=>ip.InspectedProperty.BuildingId==buildingId).
                    ToArrayAsync(cancellationToken);
        }

        public async Task<IEnumerable<InspectionProtocol>> GetProtocolsOfParticularRealProperty(Guid realPropertyId, CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionProtocols.
                Where(ip => ip.InspectedPropertyId == realPropertyId).
                    ToArrayAsync(cancellationToken);
        }
    }
}
