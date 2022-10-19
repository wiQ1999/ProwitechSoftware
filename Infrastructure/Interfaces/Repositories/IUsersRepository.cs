using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.Repositories;
public interface IUsersRepository
{
    Task<IEnumerable<User>> GetUsersAsync(CancellationToken cancellationToken);
    Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<User?> GetUserByLoginAndPasswordAsync(string login, string password, CancellationToken cancellationToken);
    Task<Guid> CreateUserAsync(User user, CancellationToken cancellationToken);
    Task UpdateUserAsync(User user, CancellationToken cancellationToken);
    Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
}
