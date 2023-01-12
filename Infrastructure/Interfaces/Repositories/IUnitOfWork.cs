using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Role> RolesRepository { get; }
    IGenericRepository<User> UsersRepository { get; }
    IGenericRepository<Permission> PermissionsRepository { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}
