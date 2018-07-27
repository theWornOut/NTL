using System;
using System.Linq;
using System.Linq.Expressions;
using NTL.Business.Interfaces;
using NTL.Infrastructure.Entity;
using NTL.Infrastructure.UnitOfWork;

namespace NTL.Business.Services
{
    public class TaskService : ITaskService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TaskService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IQueryable<TaskTable> GetAll() => _unitOfWork.GetRepository<TaskTable>().GetAll();

        public IQueryable<TaskTable> GetAll(Expression<Func<TaskTable, bool>> predicate) => _unitOfWork.GetRepository<TaskTable>().GetAll(predicate);

        public TaskTable GetById(int id) => _unitOfWork.GetRepository<TaskTable>().GetById(id);

        public TaskTable Get(Expression<Func<TaskTable, bool>> predicate) => _unitOfWork.GetRepository<TaskTable>().Get(predicate);

        public void Insert(TaskTable entity)
        {
            _unitOfWork.GetRepository<TaskTable>().Insert(entity);
            _unitOfWork.SaveChanges();
        }

        public void Update(TaskTable entity)
        {
            _unitOfWork.GetRepository<TaskTable>().Update(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(TaskTable entity)
        {
            _unitOfWork.GetRepository<TaskTable>().Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}