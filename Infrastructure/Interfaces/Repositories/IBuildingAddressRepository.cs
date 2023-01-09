using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IBuildingAddressRepository
    {
        Task<IEnumerable<BuildingAddress>> GetAllAsync(CancellationToken cancellationToken);
        Task<BuildingAddress> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<BuildingAddress> AddAsync(BuildingAddress address, CancellationToken cancellationToken);
        Task UpdateBuildingAddressAsync(BuildingAddress address, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
        Task<BuildingAddress?> FindBuildingAddress(BuildingAddress address, CancellationToken cancellationToken);
    }
}
