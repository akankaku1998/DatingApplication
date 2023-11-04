using System.Linq.Expressions;

namespace DatingApp.Repositories.BaseEntity
{
    public interface IEntityRepository<TEntity>
        where TEntity : class
    {

        IQueryable<TEntity> GetAllOrWithIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> EditAsync(TEntity entity);
    }
}