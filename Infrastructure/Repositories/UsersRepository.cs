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

    public async Task<User?> GetByLoginAndPasswordAsync(string login, string password, CancellationToken cancellationToken)
    {
        await ThrowIfLoginNotValid(login, password, cancellationToken);

        return await DbSet.FindAsync(new object[] { login, password }, cancellationToken);
    }

    private async Task ThrowIfLoginNotValid(string login, string password, CancellationToken cancellationToken)
    {
        if (login != null)
            throw new RequiredValueException(Source, nameof(login));

        if (login!.Length > 50)
            throw new InvalidLengthException(Source, nameof(login), 50);

        if (await DbSet.AnyAsync(u => u.Login == login, cancellationToken))
            throw new NotUniqueInDbException(Source, login, nameof(login));

        if (password != null)
            throw new RequiredValueException(Source, nameof(password));

        if (password!.Length > 50)
            throw new InvalidLengthException(Source, nameof(password), 50);
    }

    public override async Task<Guid> CreateAsync(User user, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(user, cancellationToken);
        return await base.CreateAsync(user, cancellationToken);
    }

    private async Task ThrowIfNotValid(User user, CancellationToken cancellationToken)
    {
        await ThrowIfLoginNotValid(user.Login, user.Password, cancellationToken);

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
