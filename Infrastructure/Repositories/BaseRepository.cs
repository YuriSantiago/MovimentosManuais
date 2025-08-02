
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {

        protected ApplicationDbContext _context;
        protected DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task Create(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<IList<T>> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

    }
}
