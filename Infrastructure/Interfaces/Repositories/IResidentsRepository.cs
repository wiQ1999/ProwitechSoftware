using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IResidentsRepository
    {
        public Task<IEnumerable<Resident>> GetAllAsync(CancellationToken cancellationToken);

        public Task<Resident?> GetAsync(Guid id, CancellationToken cancellationToken);

        public Task<Guid> AddAsync(Resident resident, CancellationToken cancellationToken);
        public Task UpdateAsync(Resident resident, CancellationToken cancellationToken);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken);

        public Task<Guid> CreateOrGetResident(Resident resident, CancellationToken cancellationToken);

        public Task<Guid> UpdateOrGetOrCreateResident(Resident newResident, Resident oldResident, Guid inspectionProtocolId, CancellationToken cancellationToken);
        public Task DeleteResidentIfNoProtocolsAreAssignedToThem(Resident resident, CancellationToken cancellationToken);
    }
}
