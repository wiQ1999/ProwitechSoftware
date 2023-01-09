using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IPropertyAddressRepository
    {
        Task<IEnumerable<PropertyAddress>> GetAllAsync(CancellationToken cancellationToken);
        Task<PropertyAddress> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Guid> AddAsync(PropertyAddress address, CancellationToken cancellationToken);
        Task UpdateAsync(PropertyAddress address, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
