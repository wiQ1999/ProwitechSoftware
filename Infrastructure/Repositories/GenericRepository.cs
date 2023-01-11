using Infrastructure.Database;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Common;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
{
    internal ProwitechDbContext Context;
    internal DbSet<TEntity> DbSet;

    public GenericRepository(ProwitechDbContext context)
    {
        Context = context;
        DbSet = context.Set<TEntity>();
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        => await DbSet.ToArrayAsync(cancellationToken);

    public virtual async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => await TryGetByIdAsync(id, cancellationToken);

    private async Task<TEntity> TryGetByIdAsync(Guid id, CancellationToken cancellationToken)
        => (await DbSet.FindAsync(new object[] { id }, cancellationToken)) ??
            throw new NotFoundInDbExcption(AppSource.Roles, id);

    public virtual async Task<Guid> CreateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await DbSet.AddAsync(entity, cancellationToken);

        return entity.Id;
    }

    public virtual async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await TryGetByIdAsync(entity.Id, cancellationToken);

        if (Context.Entry(entity).State == EntityState.Detached)
            DbSet.Attach(entity);

        Context.Entry(entity).State = EntityState.Modified;
    }

    public virtual async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        TEntity entity = await TryGetByIdAsync(id, cancellationToken);

        if (Context.Entry(entity).State == EntityState.Detached)
            DbSet.Attach(entity);

        DbSet.Remove(entity);
    }
}
