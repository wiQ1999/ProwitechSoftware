using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;
public interface IPermissionsRepository
{
    Task<IEnumerable<Permission>> GetPermissionsAsync(CancellationToken cancellationToken);
    Task UpdatePermissionsAsync(IEnumerable<Permission> permissions, CancellationToken cancellationToken);
}
