using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IFullAddressRepository
    {
        Task<IEnumerable<FullAddress>> GetAllAsync(CancellationToken cancellationToken);
        Task<FullAddress> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Guid> AddAsync(FullAddress address, CancellationToken cancellationToken);
        Task UpdateAsync(FullAddress address, CancellationToken cancellationToken);
        Task<FullAddress?> FindFullAddressWithPropertyAddress(FullAddress address, CancellationToken cancellationToken);
        Task<FullAddress?> FindFullAddressWithoutPropertyAddress(FullAddress address, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

}
