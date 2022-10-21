using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class LocalInfoRepository : ILocalInfoRepository
    {
        private readonly ProwitechDbContext _dbContext;

        public LocalInfoRepository(ProwitechDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> AddAsync(LocalInfo localInfo, CancellationToken cancellationToken)
        {
            //if (await _dbContext.Users.AnyAsync(u => u.Login == user.Login, cancellationToken)
            //if (await _dbContext.LocalInfos.AnyAsync(l=>l.)
            await _dbContext.AddAsync(localInfo, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return localInfo.Id;
        }
    }
}
