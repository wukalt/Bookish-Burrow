using KalaDuck.DataAccess.Data;
using KalaDuck.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KalaDuck.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<T> Get(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll(int taken = 0)
        {
            if (!NeedToTake(taken))
            {
                return await _dbSet.ToListAsync();
            }
            return await _dbSet.Take(taken).ToListAsync();
        }

        private bool NeedToTake(int taken)
        {
            return taken != 0 ? true : false;
        }

        public async Task Remove(T entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Remove(entity);
            });
        }
    }
}
