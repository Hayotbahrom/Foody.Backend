using Foody.Data.DbContexts;
using Foody.Data.IRepositories;
using Foody.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace Foody.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;
    public Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }
    public IQueryable<TEntity> SelectAll()
        => _dbSet;

    public async Task<TEntity> SelectIdAsync(long id)
        => await _dbSet.FirstOrDefaultAsync(e => e.Id == id);

    public async Task<bool> DeleteAsync(long id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

        _dbSet.Remove(entity);

        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var entry = await _dbSet.AddAsync(entity);

        await _dbContext.SaveChangesAsync();

        return entry.Entity;
    }


    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var entry = _dbSet.Update(entity);

        await _dbContext.SaveChangesAsync();

        return entry.Entity;
    }
}
