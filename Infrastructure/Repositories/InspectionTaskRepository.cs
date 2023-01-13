using Infrastructure.Database;
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
    public  class InspectionTaskRepository : IInspectionTaskRepository
    {
        private readonly ProwitechDbContext _dbContext;

        public InspectionTaskRepository(ProwitechDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> AddAsync(InspectionTask inspectionTask, CancellationToken cancellationToken)
        {
            var building = await _dbContext.Buildings.FirstOrDefaultAsync(b => b.Id == inspectionTask.BuildingId);
            if (building == null)
                throw new Exception($"Nie mozna utworzyć Zadania: podane Id Budynku nie istnieje");
            var delegator = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == inspectionTask.TaskDelegatorId);
            if (delegator == null)
                throw new Exception($"Nie mozna utworzyć Zadania: Nie istnieje Zlecający Zadanie o podanym Id");
            var performer = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == inspectionTask.TaskPerformerId);
            if (performer == null)
                throw new Exception($"Nie mozna utworzyć Zadania: Nie istnieje Wykonujący Zadanie o podanym Id");
            await _dbContext.AddAsync(inspectionTask);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return inspectionTask.Id;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            InspectionTask? taskToDelete = await _dbContext.InspectionTasks.FirstOrDefaultAsync(it => it.Id == id);
            if (taskToDelete == null)
                throw new Exception($"Brak Zadania o identyfikatorze {id}.");
            _dbContext.InspectionTasks.Remove(taskToDelete);
            await _dbContext.SaveChangesAsync(cancellationToken);

        }

        public async Task<IEnumerable<InspectionTask>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionTasks.
                Include(it=>it.TaskDelegator).
                Include(it=>it.TaskPerformer).
                Include(it => it.Building).
                    ThenInclude(b => b.BuildingAddress).
                Include(it => it.Building).
                    ThenInclude(b => b.PropertyManager).
                ToArrayAsync(cancellationToken);
        }

        public async Task<InspectionTask> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dbContext.InspectionTasks.
                Include(it => it.TaskDelegator).
                Include(it => it.TaskPerformer).
                Include(it=>it.Building).
                    ThenInclude(b=>b.BuildingAddress).
                Include(it => it.Building).
                    ThenInclude(b => b.PropertyManager).
                        ThenInclude(pm=>pm.FullAddress).
                            ThenInclude(fa=>fa.BuildingAddress).
                Include(it => it.Building).
                    ThenInclude(b => b.PropertyManager).
                        ThenInclude(pm => pm.FullAddress).
                            ThenInclude(fa => fa.PropertyAddress).
                Include(it=>it.InspectionProtocols).
                    ThenInclude(ip=>ip.InspectedProperty).
                        ThenInclude(p=>p.PropertyAddress).
                Include(it => it.InspectionProtocols).
                    ThenInclude(ip => ip.Resident).
                FirstOrDefaultAsync(it => it.Id == id);
        }

        public async Task UpdateAsync(InspectionTask inspectionTask, CancellationToken cancellationToken)
        {
            _dbContext.Entry(inspectionTask).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<InspectionTask>> GetTasksOfParticularPerformer(Guid userId, CancellationToken cancellationToken)
        {
            if(await _dbContext.Users.FirstOrDefaultAsync(u=>u.Id==userId)==null)
                throw new Exception($"Nie można pobrać zadań wybranego użytkownika: Użytkownik o podanym ID nie istnieje");
            return await _dbContext.InspectionTasks.
                Include(it => it.TaskDelegator).
                Include(it => it.TaskPerformer).
                Include(it => it.Building).
                    ThenInclude(b => b.BuildingAddress).
                Include(it => it.Building).
                    ThenInclude(b => b.PropertyManager).
                Where(it => it.TaskPerformerId == userId).ToArrayAsync(cancellationToken);
        }

        public async Task<IEnumerable<InspectionTask>> GetTasksOfParticularPerformerWithParticularStatus(Guid userId, string status, CancellationToken cancellationToken)
        {
            if (await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId) == null)
                throw new Exception($"Nie można pobrać zadań wybranego użytkownika o statusie {status}: Użytkownik o podanym ID nie istnieje");
            return await _dbContext.InspectionTasks.
                Include(it => it.TaskDelegator).
                Include(it => it.TaskPerformer).
                Include(it => it.Building).
                    ThenInclude(b => b.BuildingAddress).
                Include(it => it.Building).
                    ThenInclude(b => b.PropertyManager).
                Where
                (it => it.TaskPerformerId == userId 
                && it.Status==status.ToUpper()).ToArrayAsync(cancellationToken);
        }

        
    }
}
