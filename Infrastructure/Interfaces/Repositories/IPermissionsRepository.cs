using Infrastructure.Interfaces.Repositories.Generics;
using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;

public interface IPermissionsRepository : IGenericRepository<Permission>
{
    Task<IEnumerable<Permission>> GetByRoleIdAsync(Guid roleId, CancellationToken cancellationToken);
    Task<IEnumerable<Permission>> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken);
}
