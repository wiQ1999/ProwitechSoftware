using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Role> RolesRepository { get; }

    void Save();
}
