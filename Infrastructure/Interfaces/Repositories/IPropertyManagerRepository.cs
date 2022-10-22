using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface IPropertyManagerRepository
    {
        Task<IEnumerable<PropertyManager>> GetAllAsync(CancellationToken cancellationToken);
        Task<PropertyManager?> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Guid> AddAsync(PropertyManager propMan, CancellationToken cancellationToken);
        Task UpdateAsync(PropertyManager propMan, CancellationToken cancellationToken);
    }
}
