using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.Repositories.Generics;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class RepositoriesUnitOfWork : IRepositoriesUnitOfWork
{
    private readonly ProwitechDbContext _context;
    private IGenericRepository<Role>? _rolesRepository;
    private IUsersRepository? _usersRepository;
    private IPermissionsRepository? _permissionsRepository;
    private IBuildingAddressRepository? _buildingAddressRepository;
    private bool disposed = false;

    public IGenericRepository<Role> RolesRepository
        => _rolesRepository ??= new RolesRepository(_context);

    public IUsersRepository UsersRepository
        => _usersRepository ??= new UsersRepository(_context);

    public IPermissionsRepository PermissionsRepository
        => _permissionsRepository ??= new PermissionsRepository(_context);

    public IBuildingAddressRepository BuildingAddressRepository 
        => _buildingAddressRepository ??= new BuildingAddressRepository(_context);

    public RepositoriesUnitOfWork(ProwitechDbContext context)
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
