using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace VNVon.DataAccess.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();

        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);

        T Create(T entity);

        T Update(T entity);

        bool Delete(T entity);

        bool DeleteById(int id);
    }
}
