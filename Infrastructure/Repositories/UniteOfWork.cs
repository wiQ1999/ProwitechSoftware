using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories.Generics;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;

namespace Infrastructure.Repositories;

public class UniteOfWork : IRepositoriesUnitOfWork
{
    private readonly ProwitechDbContext _context;
    private IGenericRepository<Role>? _rolesRepository;
    private IGenericRepository<User>? _usersRepository;
    private IGenericRepository<Permission>? _permissionsRepository;
    private bool disposed = false;

    public IGenericRepository<Role> RolesRepository
        => _rolesRepository ??= new GenericRolesRepository(_context);

    public IGenericRepository<User> UsersRepository 
        => _usersRepository ??= new GenericUsersRepository(_context);

    public IGenericRepository<Permission> PermissionsRepository
        => _permissionsRepository ??= new GenericPermissionsRepository(_context);

    public UniteOfWork(ProwitechDbContext context)
    {
        _context = context;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
        => await _context.SaveChangesAsync();

    public void Dispose()
    {
        if (disposed)
            return;

        _context.Dispose();
        disposed = true;
    }
}
