using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;

namespace Infrastructure.Repositories;

public class UniteOfWork : IUnitOfWork
{
    private ProwitechDbContext _context;
    private IGenericRepository<Role>? _rolesRepository;
    private bool disposed = false;

    public IGenericRepository<Role> RolesRepository
        => _rolesRepository ??= new GenericRoleRepository(_context);

    public UniteOfWork(ProwitechDbContext context)
    {
        _context = context;
    }

    public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();

    public void Dispose()
    {
        if (disposed)
            return;

        _context.Dispose();
        disposed = true;
    }
}
