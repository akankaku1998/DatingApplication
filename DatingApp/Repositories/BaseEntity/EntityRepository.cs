using System.Linq.Expressions;
using System.Reflection;
using DatingApp.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Repositories.BaseEntity
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        public EntityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> EditAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<TEntity> GetAllOrWithIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = _context.Set<TEntity>().AsQueryable();

            if (includeProperties != null)
            {
                query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }
            return query;
        }
    }
}