namespace Infrastructure.Interfaces.Repositories.Generics;

public interface IGenericRepository<TEntity>  : 
    IGenericGetAll<TEntity>, 
    IGenericGetById<TEntity>, 
    IGenericCreate<TEntity>, 
    IGenericUpdate<TEntity>,
    IGenericDelete
    where TEntity : class
{ }
