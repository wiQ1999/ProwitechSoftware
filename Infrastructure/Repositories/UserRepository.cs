using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class UsersRepository : IUsersRepository
{
    private readonly ProwitechDbContext _dbContext;

    public UsersRepository(ProwitechDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<User>> GetUsersAsync(CancellationToken cancellationToken) =>
        await _dbContext.Users.Include(u => u.Role)
        .ToArrayAsync(cancellationToken);

    public async Task<User?> GetUserByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await _dbContext.Users.Include(u => u.Role)
        .SingleOrDefaultAsync(u => u.Id == id, cancellationToken) ?? 
        throw new Exception($"Brak użytkownika o identyfikatorze {id}.");

    public async Task<User?> GetUserByLoginAndPasswordAsync(string login, string password, CancellationToken cancellationToken) =>
        await _dbContext.Users.Include(u => u.Role)
        .SingleOrDefaultAsync(u => u.Login == login && u.Password == password, cancellationToken);

    public async Task<Guid> CreateUserAsync(User user, CancellationToken cancellationToken)
    {
        if (await _dbContext.Users.AnyAsync(u => u.Login == user.Login, cancellationToken))
            throw new Exception($"Istnieje już użytkownik o loginie {user.Login}.");
        if (!string.IsNullOrEmpty(user.Email) && await _dbContext.Users.AnyAsync(u => u.Email == user.Email, cancellationToken))
            throw new Exception($"Istnieje już użytkownik o adresie email {user.Email}.");
        await _dbContext.Users.AddAsync(user, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return user.Id;
    }

    public async Task UpdateUserAsync(User user, CancellationToken cancellationToken)
    {
        _dbContext.Entry(user).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteUserAsync(Guid id, CancellationToken cancellationToken)
    {
        User? user = await _dbContext.Users
            .SingleOrDefaultAsync(u => u.Id == id, cancellationToken);
        if (user == null)
            throw new Exception($"Brak użytkownika o identyfikatorze {id}.");
        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
