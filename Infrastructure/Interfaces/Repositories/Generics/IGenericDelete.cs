namespace Infrastructure.Interfaces.Repositories.Generics;

public interface IGenericDelete
{
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
