using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using Infrastructure.Repositories.Generics;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Infrastructure.Repositories;

public class PermissionsRepository : GenericRepository<Permission>, IPermissionsRepository
{
    public PermissionsRepository(ProwitechDbContext dbContext)
        : base(dbContext, AppSource.Permissions)
    { }

    public async Task<IEnumerable<Permission>> GetByRoleIdAsync(Guid roleId, CancellationToken cancellationToken)
        => await DbSet.Where(p => p.RoleId == roleId).ToArrayAsync(cancellationToken);

    public async Task<IEnumerable<Permission>> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken)
        => await DbSet.Where(p => p.UserId == userId).ToArrayAsync(cancellationToken);

    public override async Task<Guid> CreateAsync(Permission permission, CancellationToken cancellationToken)
    {
        ThrowIfNotValid(permission);
        await ThrowIfNotUnique(permission, cancellationToken);
        return await base.CreateAsync(permission, cancellationToken);
    }

    private void ThrowIfNotValid(Permission permission)
    {
        bool isHostsNull = permission.RoleId == null && permission.UserId == null;
        bool isHostsNotNull = permission.RoleId != null && permission.UserId != null;

        if (isHostsNull || isHostsNotNull)
            throw new RequiredValueException("Uprawnienie musi być przypisane do roli lub użytkownika.");       
    }

    private async Task ThrowIfNotUnique(Permission permission, CancellationToken cancellationToken)
    {
        bool isHostSourceNotUnique = await DbSet.AnyAsync(p =>
            p.Source == permission.Source &&
            (
                (p.RoleId != null && p.RoleId == permission.RoleId) || 
                (p.UserId != null && p.UserId == permission.UserId)
            ),
            cancellationToken);

        if (isHostSourceNotUnique)
            throw new NotUniqueInDbException(Source, permission.Id);
    }

    public override async Task UpdateAsync(Permission permission, CancellationToken cancellationToken)
    {
        ThrowIfNotValid(permission);
        await base.UpdateAsync(permission, cancellationToken);
    }
}
