using Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Interfaces
{
    public interface IRepository<TKey, T> where T : EntityBase
    {
        T GetById(TKey Id); 
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool >> predicate);
        IEnumerable<T> DeleteAll();
        IEnumerable<T> DeleteAll(Expression<Func<T, bool>> predicate);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
