using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IRealPropertyRepository
    {
        Task<bool> CheckIfRealPropertyAlreadyExists(RealProperty property, CancellationToken cancellationToken);
        Task<IEnumerable<RealProperty>> GetAllAsync(CancellationToken cancellationToken);
        Task<RealProperty?> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Guid> AddAsync(RealProperty property, CancellationToken cancellationToken);
        Task UpdateAsync(RealProperty property, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);

        Task <RealProperty?> GetOnePropertyOfParticularBuilding(Guid buildingId, CancellationToken cancellationToken);
        Task<IEnumerable<RealProperty>> GetAllPropertiesOfBuilding(Guid buildingId, CancellationToken cancellationToken);
    }
}
