using System;
using System.Linq;
using System.Linq.Expressions;

namespace NTL.Business.Interfaces
{
    public interface IBusinessService<T> : IDisposable where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T Get(Expression<Func<T, bool>> predicate);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}