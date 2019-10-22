using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace VNVon.Service.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> predicate);
        bool Create(T entity);
        bool Delete(T entity);
        bool Edit(T entity);
    }
}
