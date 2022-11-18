

namespace GoogleKeepClone_DotNetAPI.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAsync();
        Task DeleteAsync(int id);
        Task UpdateAsync(TEntity entity);
    }
}
