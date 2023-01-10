using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    internal ProwitechDbContext Context;
    internal DbSet<TEntity> DbSet;

    public GenericRepository(ProwitechDbContext context)
    {
        Context = context;
        DbSet = context.Set<TEntity>();
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await DbSet.ToArrayAsync(cancellationToken);
    }

    public virtual async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return (await DbSet.FindAsync(id, cancellationToken))!;
    }

    public virtual async Task InsertAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await DbSet.AddAsync(entity, cancellationToken);
    }

    public virtual async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        DbSet.Attach(entity);
        Context.Entry(entity).State = EntityState.Modified;
    }

    public virtual async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        TEntity entity = await GetByIdAsync(id, cancellationToken);

        if (Context.Entry(entity).State == EntityState.Detached)
            DbSet.Attach(entity);

        DbSet.Remove(entity);
    }
}
