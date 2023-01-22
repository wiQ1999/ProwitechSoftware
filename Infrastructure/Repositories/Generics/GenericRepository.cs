using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories.Generics;
using Infrastructure.Models.Common;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Generics;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
{
    internal ProwitechDbContext Context;
    internal DbSet<TEntity> DbSet;
    internal AppSource Source;

    public GenericRepository(ProwitechDbContext context, AppSource source)
    {
        Context = context;
        DbSet = context.Set<TEntity>();
        Source = source;
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        => await DbSet.ToArrayAsync(cancellationToken);

    public virtual async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => await DbSet.FindAsync(new object[] { id }, cancellationToken) ??
            throw new NotFoundInDbExcption(Source, id);

    public virtual async Task<Guid> CreateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await DbSet.AddAsync(entity, cancellationToken);

        return entity.Id;
    }

    public virtual async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await GetByIdAsync(entity.Id, cancellationToken);

        if (Context.Entry(entity).State == EntityState.Detached)
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
