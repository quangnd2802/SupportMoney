using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using VNVon.DataAccess.Interfaces;

namespace VNVon.DataAccess.Implements
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        public RepositoryBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public T Create(T entity)
        {
            var newItem = _unitOfWork.Context.Set<T>().Add(entity);
            return newItem.Entity;
        }

        public bool Delete(T entity)
        {
            var result = false;

            T existing = _unitOfWork.Context.Set<T>().Find(entity);
            if (existing != null)
            {
                _unitOfWork.Context.Set<T>().Remove(existing);
                result = true;
            }

            return result;
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll()
        {
            return _unitOfWork.Context.Set<T>().ToList();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _unitOfWork.Context.Set<T>().Where(expression).ToList();
        }

        public T Update(T entity)
        {
            var result = entity;
            try
            {
                _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
                _unitOfWork.Context.Set<T>().Attach(entity);
            }
            catch(Exception ex)
            {
                result = null;
            }

            return result;
        }
    }
}
