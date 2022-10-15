using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Infrastructure.Repositories;
public class PermissionRepository : IPermissionsRepository
{
    private readonly ProwitechDbContext _dbContext;

    public PermissionRepository(ProwitechDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Permission>> GetRolePermissionsAsync(
        Guid roleId, CancellationToken cancellationToken) =>
        await _dbContext.Permissions
        .Where(p => p.RoleId == roleId)
        .ToArrayAsync(cancellationToken);

    public async Task<IEnumerable<Permission>> GetUserPermissionsAsync(
        Guid userId, CancellationToken cancellationToken) =>
        await _dbContext.Permissions
        .Where(p => p.UserId == userId)
        .ToArrayAsync(cancellationToken);

    public async Task<Guid> CreatePermissionsAsync(
        Permission permission, CancellationToken cancellation)
    {
        if (permission.RoleId == null && permission.UserId == null)
            throw new Exception("Uprawnienie musi być przypisane do roli lub użytkownika");
        if (permission.Create == null && permission.Read == null &&
            permission.Update == null && permission.Delete == null)
            throw new Exception("Należy uzupełnić przynajmniej jedno prawo");
        await _dbContext.Permissions.AddAsync(permission, cancellation);
        await _dbContext.SaveChangesAsync(cancellation);
        return permission.Id;
    }

    public async Task UpdatePermissionsAsync(
        Permission permission, CancellationToken cancellationToken)
    {
        _dbContext.Entry(permission).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
