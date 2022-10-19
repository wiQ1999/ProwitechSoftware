using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IBuildingRepository
    {
        Task<IEnumerable<Building>> GetAllAsync(CancellationToken cancellationToken);
        Task<Building> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Building> AddAsync(Building building, CancellationToken cancellationToken);
        Task UpdateBuildingAsync(Building building, CancellationToken cancellationToken);
    }
}
