using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;
public interface IPermissionsRepository
{
    Task<IEnumerable<Permission>> GetRolePermissionsAsync(Guid roleId, CancellationToken cancellationToken);
    Task<IEnumerable<Permission>> GetUserPermissionsAsync(Guid userId, CancellationToken cancellationToken);
    Task<Guid> CreatePermissionsAsync(Permission permission, CancellationToken cancellation);
    Task UpdatePermissionsAsync(Permission permission, CancellationToken cancellationToken);
    Task DeletePermissionsAsync(Guid id, CancellationToken cancellationToken);
}
