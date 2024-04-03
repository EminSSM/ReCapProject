using Core.Entities;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntityBase, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GetBy(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
