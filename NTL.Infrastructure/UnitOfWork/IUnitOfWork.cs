using NTL.Infrastructure.Repository;

namespace NTL.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class;
        void SaveChanges();
        void Dispose();
    }
}