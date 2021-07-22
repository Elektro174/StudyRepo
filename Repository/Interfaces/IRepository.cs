using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<TKey, T> where T : EntityBase
    {
        T GetById(TKey Id); //  Guid id
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool >> predicate);
        IEnumerable<T> DeleteAll();
        IEnumerable<T> DeleteAll(Expression<Func<T, bool>> predicate);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);

        IEnumerable<T> UserSingUp();
        IEnumerable<T> UserSingUp(Expression<Func<T, bool>> predicate);


    }
}
