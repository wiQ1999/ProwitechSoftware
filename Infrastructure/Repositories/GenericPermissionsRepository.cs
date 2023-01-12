using Infrastructure.Common.Helpers;
using Infrastructure.Database;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;

namespace Infrastructure.Repositories;

public class GenericPermissionsRepository : GenericRepository<Permission>
{
    public GenericPermissionsRepository(ProwitechDbContext dbContext)
        : base(dbContext, AppSource.Permissions)
    { }

    public override async Task<Guid> CreateAsync(Permission permission, CancellationToken cancellationToken)
    {
        ThrowIfNotValid(permission, cancellationToken);
        return await base.CreateAsync(permission, cancellationToken);
    }

    private void ThrowIfNotValid(Permission permission, CancellationToken cancellationToken)
    {
        if (permission.UserId == null && permission.RoleId == null)
            throw new Exception($"Rekord w zasobach \"{Source.GetDescription()}\" musi być przypisany do użytkownika lub roli.");
    }

    public override async Task UpdateAsync(Permission permission, CancellationToken cancellationToken)
    {
        ThrowIfNotValid(permission, cancellationToken);
        await base.UpdateAsync(permission, cancellationToken);
    }
}
