using SQLite;

namespace Wkxvii.Abstractions.Dao;

public abstract class BaseDao<TEntity>
    where TEntity : class, new()
{
    protected static SQLiteAsyncConnection Connection =>
        DaoContext.Instance?.Connection ?? throw new DaoContextConnectionNotInitializedException();

    public virtual Task<int> InsertAsync(TEntity ent) => Connection.InsertAsync(ent);

    public virtual Task<int> InsertOrUpdateAsync(TEntity ent) =>
        Connection.InsertOrReplaceAsync(ent);

    public virtual Task<List<TEntity>> GetAllAsync() => Connection.Table<TEntity>().ToListAsync();

    public virtual Task<TEntity> GetAsync<PKType>(PKType id) => Connection.GetAsync<TEntity>(id);

    public virtual Task<int> UpdateAsync(TEntity ent) => Connection.UpdateAsync(ent);

    public virtual Task<int> DeleteAsync(TEntity ent) => Connection.DeleteAsync(ent);

    public virtual Task<int> DeleteAsync<PKType>(PKType id) => Connection.DeleteAsync<TEntity>(id);
}
