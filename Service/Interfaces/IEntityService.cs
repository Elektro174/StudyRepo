using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Models;

namespace Service.Interfaces
{
    public interface IEntityService<TKey ,T> : IService where T : EntityBase
    {
        T GetById(TKey Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        IEnumerable<T> DeleteAll();
        IEnumerable<T> DeleteAll(Expression<Func<T, bool>> predicate);
        void Create(T entity);
        void CreateMultipal(IEnumerable<T> entities);
        void Delete(T entity);
        void Update(T entity);
    }
}
