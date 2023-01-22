using Infrastructure.Interfaces.Repositories.Generics;
using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;

public interface IUsersRepository : IGenericRepository<User>
{
    Task<User?> GetByLoginAsync(string login, CancellationToken cancellationToken);
}
