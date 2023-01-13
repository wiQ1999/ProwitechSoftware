using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using Infrastructure.Repositories.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UsersRepository : GenericRepository<User>, IUsersRepository
{
    public UsersRepository(ProwitechDbContext dbContext) 
        : base(dbContext, AppSource.Users)
    { }

    public override async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken)
        => await DbSet.Include(u => u.Role).ToArrayAsync(cancellationToken);

    public override async Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => await DbSet.Include(u => u.Role).FirstOrDefaultAsync(u => u.Id == id, cancellationToken) ??
            throw new NotFoundInDbExcption(Source, id);

    public async Task<User?> GetByLoginAndPasswordAsync(string login, string password, CancellationToken cancellationToken)
        => await DbSet
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u => u.Login == login && u.Password == password, cancellationToken);

    public override async Task<Guid> CreateAsync(User user, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(user, cancellationToken);
        return await base.CreateAsync(user, cancellationToken);
    }

    private async Task ThrowIfNotValid(User user, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(user.Login))
            throw new RequiredValueException(Source, nameof(user.Login));

        if (user.Login!.Length > 50)
            throw new InvalidLengthException(Source, nameof(user.Login), 50);

        if (await DbSet.AnyAsync(u => u.Login == user.Login && u.Id != user.Id, cancellationToken))
            throw new NotUniqueInDbException(Source, user.Login, nameof(user.Login));

        if (string.IsNullOrWhiteSpace(user.Password))
            throw new RequiredValueException(Source, nameof(user.Password));

        if (user.Password!.Length > 50)
            throw new InvalidLengthException(Source, nameof(user.Password), 50);

        if (user.FirstName != null && user.FirstName.Length > 50)
            throw new InvalidLengthException(Source, nameof(user.FirstName), 50);

        if (user.LastName != null && user.LastName.Length > 50)
            throw new InvalidLengthException(Source, nameof(user.LastName), 50);

        if (user.Email != null && user.Email.Length > 50)
            throw new InvalidLengthException(Source, nameof(user.Email), 50);

        if (user.PhoneNumber != null && user.PhoneNumber.Length > 50)
            throw new InvalidLengthException(Source, nameof(user.PhoneNumber), 50);
    }

    public override async Task UpdateAsync(User user, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(user, cancellationToken);
        await base.UpdateAsync(user, cancellationToken);
    }
}
