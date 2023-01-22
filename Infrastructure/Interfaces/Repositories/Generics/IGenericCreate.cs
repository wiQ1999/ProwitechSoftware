namespace Infrastructure.Interfaces.Repositories.Generics;

public interface IGenericCreate<TEntity> where TEntity : class
{
    Task<Guid> CreateAsync(TEntity entity, CancellationToken cancellationToken);
}
