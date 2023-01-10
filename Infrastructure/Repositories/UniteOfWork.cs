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
        => _rolesRepository ??= new GenericRepository<Role>(_context);

    public UniteOfWork(ProwitechDbContext context)
    {
        _context = context;
    }

    public void Save()
        => _context.SaveChanges();

    public void Dispose()
    {
        if (disposed)
            return;

        _context.Dispose();
        disposed = true;
    }
}
