using Microsoft.EntityFrameworkCore;
using WpfApp1.Data.DbContexts;
using WpfApp1.Data.IGenericRepositories;
using WpfApp1.Domain.Commons;

namespace WpfApp1.Data.GenericRepositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        private readonly WpfApp1DbContext _dbContext;

        private readonly DbSet<T> dbSet;
        public GenericRepository()
        {
            _dbContext = new WpfApp1DbContext();
            dbSet = _dbContext.Set<T>();
        }

        public async Task<bool> AddAsync(T entity)
        {
            entity.CreatedTime = DateTime.UtcNow;
           
            await dbSet.AddAsync(entity);

            await _dbContext.SaveChangesAsync();
            
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetAsync(id);

            dbSet.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateAsync(T entity)
        {

            dbSet.Update(entity);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public List<T> GetAll()
        {
            var list = dbSet.OrderBy(e => e.Id).ToList();

            return list;
        }
        public async Task<T> GetAsync(int id)
        {
            var entity = await dbSet.FirstOrDefaultAsync(e => e.Id == id);

            return entity;
        }
    }
}
