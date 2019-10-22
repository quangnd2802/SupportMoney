using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using VNVon.DataAccess.Interfaces;
using VNVon.Service.Interfaces;

namespace VNVon.Service.Implements
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected readonly IRepositoryBase<T> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public ServiceBase(IUnitOfWork unitOfWork, IRepositoryBase<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public bool Create(T entity)
        {
            var result = false;
            try
            {
                _repository.Create(entity);
                _unitOfWork.Save();
                result = true;
            }
            catch(Exception ex)
            {
                result = false;
            }

            return result;
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Edit(T entity)
        {
            var result = false;
            try
            {
                _repository.Update(entity);
                _unitOfWork.Save();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;

        }

        public IEnumerable<T> FindAll()
        {
            return _repository.FindAll();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> predicate)
        {
            return _repository.FindByCondition(predicate);
        }
    }
}
