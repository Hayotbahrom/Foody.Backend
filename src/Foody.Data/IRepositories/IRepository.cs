using Foody.Domain.Commons;

namespace Foody.Data.IRepositories;

public interface IRepository<TEntity> where TEntity : Auditable
{
    Task<TEntity> InsertAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<bool> DeleteAsync(long id);
    Task<TEntity> SelectIdAsync(long id);
    IQueryable<TEntity> SelectAll();
}
