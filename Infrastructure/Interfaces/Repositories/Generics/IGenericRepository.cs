namespace Infrastructure.Interfaces.Repositories.Generics;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken);

    Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<Guid> CreateAsync(TEntity entity, CancellationToken cancellationToken);

    Task UpdateAsync(TEntity entityToUpdate, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
