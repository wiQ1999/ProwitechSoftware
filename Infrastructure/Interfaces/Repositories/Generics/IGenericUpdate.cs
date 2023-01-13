namespace Infrastructure.Interfaces.Repositories.Generics;

public interface IGenericUpdate<TEntity> where TEntity : class
{
    Task UpdateAsync(TEntity entityToUpdate, CancellationToken cancellationToken);
}
