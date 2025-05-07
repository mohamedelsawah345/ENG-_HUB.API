namespace ENG__HUB.API.Services.Implementation
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly ApplicationDBContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericService(ApplicationDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken=default)
        {
            return await _dbSet.ToListAsync( cancellationToken);
        }

        public async Task<T?> GetByIdAsync(object id , CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(id,cancellationToken);
        }

        public async Task<T> AddAsync(T entity , CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync( cancellationToken);
            return entity;
        }

        public async Task<bool> UpdateAsync(T entity , CancellationToken cancellationToken = default)
        {
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync(cancellationToken) > 0;
        }

        public async Task<bool> DeleteAsync(object id , CancellationToken cancellationToken = default)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return false;

            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
