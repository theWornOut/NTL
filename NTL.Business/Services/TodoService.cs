using System;
using System.Linq;
using System.Linq.Expressions;
using NTL.Business.Interfaces;
using NTL.Infrastructure.Entity;
using NTL.Infrastructure.UnitOfWork;

namespace NTL.Business.Services
{
    public class TodoService : ITodoService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TodoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IQueryable<TodoTable> GetAll() => _unitOfWork.GetRepository<TodoTable>().GetAll();

        public IQueryable<TodoTable> GetAll(Expression<Func<TodoTable, bool>> predicate) => _unitOfWork.GetRepository<TodoTable>().GetAll(predicate);

        public TodoTable GetById(int id) => _unitOfWork.GetRepository<TodoTable>().GetById(id);

        public TodoTable Get(Expression<Func<TodoTable, bool>> predicate) => _unitOfWork.GetRepository<TodoTable>().Get(predicate);

        public void Insert(TodoTable entity)
        {
            _unitOfWork.GetRepository<TodoTable>().Insert(entity);
            _unitOfWork.SaveChanges();
        }

        public void Update(TodoTable entity)
        {
            _unitOfWork.GetRepository<TodoTable>().Update(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(TodoTable entity)
        {
            _unitOfWork.GetRepository<TodoTable>().Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}