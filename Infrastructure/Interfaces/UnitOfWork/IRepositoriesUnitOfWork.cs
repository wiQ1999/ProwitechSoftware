using Infrastructure.Interfaces.Repositories.Generics;
using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.UnitOfWork;

public interface IRepositoriesUnitOfWork : IDisposable
{
    IGenericRepository<Role> RolesRepository { get; }
    IGenericRepository<User> UsersRepository { get; }
    IGenericRepository<Permission> PermissionsRepository { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}
