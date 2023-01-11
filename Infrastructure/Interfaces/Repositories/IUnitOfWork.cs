using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Role> RolesRepository { get; }

    Task SaveChangesAsync();
}
