using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class RoleRepository : IRoleRepository
{
    private readonly ProwitechDbContext _dbContext;

    public RoleRepository(ProwitechDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Role>> GetRolesAsync(CancellationToken cancellationToken) =>
        await _dbContext.Roles.ToArrayAsync(cancellationToken);

    public async Task<Role?> GetRoleByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await _dbContext.Roles.SingleOrDefaultAsync(u => u.Id == id, cancellationToken);

    public async Task<Guid> CreateRoleAsync(Role role, CancellationToken cancellationToken)
    {
        if (await _dbContext.Roles.AnyAsync(r => r.Name == role.Name, cancellationToken))
            throw new Exception($"Istnieje już rola o nazwie {role.Name}.");
        _dbContext.Roles.Add(role);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return role.Id;
    }

    public async Task UpdateRoleAsync(Role role, CancellationToken cancellationToken)
    {
        _dbContext.Entry(role).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteRoleAsync(Guid id, CancellationToken cancellationToken)
    {
        Role? role = await _dbContext.Roles.SingleOrDefaultAsync(r => r.Id == id, cancellationToken);
        if (role == null)
            throw new Exception($"Brak roli o identyfikatorze {id}.");
        _dbContext.Roles.Remove(role);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
