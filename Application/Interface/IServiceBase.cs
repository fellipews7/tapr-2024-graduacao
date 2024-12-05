using System.Linq.Expressions;

namespace Domain.Interface.Repository
{
    public interface IServiceBase <T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        IQueryable<T> Query();
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<T> FirstAsync(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        Task Commit();
    }
}
