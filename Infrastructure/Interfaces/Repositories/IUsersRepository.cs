using Infrastructure.Interfaces.Repositories.Generics;
using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;

public interface IUsersRepository : IGenericRepository<User>
{
    Task<User?> GetByLoginAndPasswordAsync(string login, string password, CancellationToken cancellationToken);
}
