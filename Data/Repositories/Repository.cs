using GoogleKeepClone_DotNetAPI.Data.Repositories;
using Microsoft.EntityFrameworkCore;


namespace GoogleKeepClone_DotNetAPI.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
         
            return entity;
        }

        public virtual async Task DeleteAsync(int id)
        {
             var entity = await this.GetByIdAsync(id);
            _context.Set<TEntity>().Remove(entity);

            await _context.SaveChangesAsync();
        }

        public virtual async Task<List<TEntity>> GetAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
