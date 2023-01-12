using Infrastructure.Database;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRoleRepository : GenericRepository<Role>
{
    public GenericRoleRepository(ProwitechDbContext dbContext) : base(dbContext)
    { }

    public override async Task<Guid> CreateAsync(Role role, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(role, cancellationToken);
        return await base.CreateAsync(role, cancellationToken);
    }

    private async Task ThrowIfNotValid(Role role, CancellationToken cancellationToken)
    {
        if (role.Name == null)
            throw new RequiredValueException(AppSource.Roles, nameof(role.Name));

        if (await DbSet.AnyAsync(r => r.Name == role.Name, cancellationToken))
            throw new NotUniqueInDbException(AppSource.Roles, role.Name, nameof(role.Name));
    }

    public override async Task UpdateAsync(Role role, CancellationToken cancellationToken)
    {
        await ThrowIfNotValid(role, cancellationToken);
        await base.UpdateAsync(role, cancellationToken);
    }
}
