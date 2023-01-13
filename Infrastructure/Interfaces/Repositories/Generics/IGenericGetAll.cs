namespace Infrastructure.Interfaces.Repositories.Generics;

public interface IGenericGetAll<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken);
}
