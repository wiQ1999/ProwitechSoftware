using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;
public interface IRoleRepository
{
    Task<IEnumerable<Role>> GetRolesAsync(CancellationToken cancellationToken);
    Task<Role> GetRoleByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<Guid> CreateRoleAsync(Role role, CancellationToken cancellationToken);
    Task UpdateRoleAsync(Role role, CancellationToken cancellationToken);
    Task DeleteRoleAsync(Guid id, CancellationToken cancellationToken);
    Task DeleteRolesAsync(Guid[] ids, CancellationToken cancellationToken);
}
