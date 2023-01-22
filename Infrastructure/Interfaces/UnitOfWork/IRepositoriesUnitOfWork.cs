using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.Repositories.Generics;
using Infrastructure.Models.Domain;

namespace Infrastructure.Interfaces.UnitOfWork;

public interface IRepositoriesUnitOfWork : IDisposable
{
    IGenericRepository<Role> RolesRepository { get; }
    IUsersRepository UsersRepository { get; }
    IPermissionsRepository PermissionsRepository { get; }

    IBuildingAddressRepository BuildingAddressRepository { get; }
    
    IBuildingRepository BuildingRepository { get; }
    IFullAddressRepository FullAddressRepository { get; }
    IInspectionTaskRepository InspectionTaskRepository { get; }
    IPropertyAddressRepository PropertyAddressRepository { get; }
    IPropertyManagerRepository PropertyManagerRepository { get; }
    IRealPropertyRepository RealPropertyRepository { get; }
    IInspectionProtocolsRepository InspectionProtocolsRepository { get; }

    IResidentsRepository ResidentsRepository { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}
