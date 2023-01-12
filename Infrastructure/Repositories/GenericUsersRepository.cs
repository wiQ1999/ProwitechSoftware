using Infrastructure.Database;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericUsersRepository : GenericRepository<User>
{
    public GenericUsersRepository(ProwitechDbContext dbContext) 
        : base(dbContext, AppSource.Users)
    { }

    public override async Task<Guid> CreateAsync(User role, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(role, cancellationToken);
        return await base.CreateAsync(role, cancellationToken);
    }

    private async Task ThrowIfNotValid(User user, CancellationToken cancellationToken)
    {
        if (user.Login != null)
            throw new RequiredValueException(Source, nameof(user.Login));

        if (user.Login!.Length > 50)
            throw new InvalidLengthException(Source, nameof(user.Login), 50);

        if (await DbSet.AnyAsync(u => u.Login == user.Login, cancellationToken))
            throw new NotUniqueInDbException(Source, user.Login, nameof(user.Login));

        if (user.Password != null)
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

    public override async Task UpdateAsync(User role, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(role, cancellationToken);
        await base.UpdateAsync(role, cancellationToken);
    }
}
