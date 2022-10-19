using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class RoleRepository : IRoleRepository
{
    private readonly ProwitechDbContext _dbContext;

    public RoleRepository(ProwitechDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Role>> GetRolesAsync(CancellationToken cancellationToken) 
        => await _dbContext.Roles.ToArrayAsync(cancellationToken);

    public async Task<Role> GetRoleByIdAsync(Guid id, CancellationToken cancellationToken)
        => await TryGetRoleByIdAsync(id, cancellationToken);

    private async Task<Role> TryGetRoleByIdAsync(Guid id, CancellationToken cancellationToken)
        => (await _dbContext.Roles.FirstOrDefaultAsync(u
            => u.Id == id, cancellationToken)) ??
                throw new NotFoundInDbExcption(AppSource.Roles, id);

    public async Task<Guid> CreateRoleAsync(Role role, CancellationToken cancellationToken)
    {
        if (await _dbContext.Roles.AnyAsync(r => r.Name == role.Name, cancellationToken))
            throw new NotUniqueInDbException(AppSource.Roles, nameof(role.Name), role.Name);
        await _dbContext.Roles.AddAsync(role, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return role.Id;
    }

    public async Task UpdateRoleAsync(Role role, CancellationToken cancellationToken)
    {
        await TryGetRoleByIdAsync(role.Id, cancellationToken);
        _dbContext.Entry(role).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteRoleAsync(Guid id, CancellationToken cancellationToken)
    {
        Role role = await TryGetRoleByIdAsync(id, cancellationToken);
        _dbContext.Roles.Remove(role);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
