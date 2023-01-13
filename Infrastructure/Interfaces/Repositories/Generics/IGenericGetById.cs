namespace Infrastructure.Interfaces.Repositories.Generics;

public interface IGenericGetById<TEntity> where TEntity : class
{
    Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
