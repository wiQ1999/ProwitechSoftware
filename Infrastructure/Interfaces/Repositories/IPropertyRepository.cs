using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IPropertyRepository
    {
        Task<IEnumerable<Property>> GetAllAsync(CancellationToken cancellationToken);
        Task<Property?> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Guid> AddAsync(Property property, CancellationToken cancellationToken);
        Task UpdateAsync(Property property, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);

        Task <Property?> GetPropertyOfParticularBuilding(Guid buildingId, CancellationToken cancellationToken);
    }
}
