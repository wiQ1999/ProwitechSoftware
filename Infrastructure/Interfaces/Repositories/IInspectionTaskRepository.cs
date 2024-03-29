﻿using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IInspectionTaskRepository
    {
        Task<IEnumerable<InspectionTask>> GetAllAsync(CancellationToken cancellationToken);
        Task<InspectionTask> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Guid> AddAsync(InspectionTask inspectionTask, CancellationToken cancellationToken);
        Task UpdateAsync(InspectionTask inspectionTask, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<InspectionTask>> GetTasksOfParticularPerformer(Guid userId, CancellationToken cancellationToken);
        Task<IEnumerable<InspectionTask>> GetTasksOfParticularPerformerWithParticularStatus(Guid userId, string status, CancellationToken cancellationToken);
    }
}
