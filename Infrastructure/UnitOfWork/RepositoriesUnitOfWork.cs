﻿using Infrastructure.Database;
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
    private IBuildingRepository? _buildingRepository;
    private IFullAddressRepository? _fullAddressRepository;
    private IInspectionTaskRepository? _inspectionTaskRepository;
    private IPropertyAddressRepository? _propertyAddressRepository;
    private IPropertyManagerRepository? _propertyManagerRepository;
    private IRealPropertyRepository? _realPropertyRepository;
    private IInspectionProtocolsRepository? _inspectionProtocolsRepository;
    private IResidentsRepository? _residentsRepository;
    private bool disposed = false;

    public IGenericRepository<Role> RolesRepository
        => _rolesRepository ??= new RolesRepository(_context);

    public IUsersRepository UsersRepository
        => _usersRepository ??= new UsersRepository(_context);

    public IPermissionsRepository PermissionsRepository
        => _permissionsRepository ??= new PermissionsRepository(_context);

    public IBuildingAddressRepository BuildingAddressRepository 
        => _buildingAddressRepository ??= new BuildingAddressRepository(_context);

    public IBuildingRepository BuildingRepository 
        => _buildingRepository ??= new BuildingRepository(_context);

    public IFullAddressRepository FullAddressRepository
        => _fullAddressRepository ??= new FullAddressRepository(_context);

    public IInspectionTaskRepository InspectionTaskRepository
        => _inspectionTaskRepository ??= new InspectionTaskRepository(_context);

    public IPropertyAddressRepository PropertyAddressRepository
        => _propertyAddressRepository ??= new PropertyAddressRepository(_context);

    public IPropertyManagerRepository PropertyManagerRepository
        => _propertyManagerRepository ??= new PropertyManagerRepository(_context);

    public IRealPropertyRepository RealPropertyRepository
        => _realPropertyRepository ??= new RealPropertyRepository(_context);

    public IInspectionProtocolsRepository InspectionProtocolsRepository
        => _inspectionProtocolsRepository ??= new InspectionProtocolsRepository(_context);

    public IResidentsRepository ResidentsRepository
        => _residentsRepository ??= new ResidentsRepository(_context);

    public RepositoriesUnitOfWork(ProwitechDbContext context)
    {
        _context = context;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
        => await _context.SaveChangesAsync(cancellationToken);

    public void Dispose()
    {
        if (disposed)
            return;

        _context.Dispose();
        disposed = true;
    }
}
