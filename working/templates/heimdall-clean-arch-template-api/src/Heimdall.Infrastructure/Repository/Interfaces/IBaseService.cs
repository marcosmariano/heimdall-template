namespace Heimdall.Infrastructure.Repository.Interfaces
{
    public interface IBaseService<TEntity, TId> : IDisposable where TEntity : class
    {
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(TId id);
        Task DeleteAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
    }
}