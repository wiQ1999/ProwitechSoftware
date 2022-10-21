using Infrastructure.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces.Repositories
{
    public interface ILocalInfoRepository
    {
        Task<Guid> AddAsync(LocalInfo localInfo, CancellationToken cancellationToken);
    }
}
