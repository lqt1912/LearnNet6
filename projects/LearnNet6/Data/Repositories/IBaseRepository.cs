
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace LearnNet6.Data.Repositories
{
    public interface IBaseRepository<T> where T : class
    {

        IQueryable<T> GetAll();

        T GetById(Guid id);

        Task<T> GetAsyncById(Guid id);
        T Find(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        T GetByIdAsDetached(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Guid id);
        bool Exists(Guid id);
        int SaveChanges();
        Task<int> SaveChangesAsync();
        int Count();
        Task<int> CountAsync();
        Task<IEnumerable<T>> ListAsync();

        Task<IEnumerable<T>> ListAsync(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        Task<IEnumerable<T>> ListAsync(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> includeProperties = null);

        IQueryable<T> ExecuteSqlRaw(string query, params object[] parameters);
        IQueryable<T> ExecuteSqlRawForQueryType(string query);
        int ExecuteNoneQuery(string query, params object[] parameters);

    }
}
