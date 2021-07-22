using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<TKey, T> : IRepository<TKey, T> where T : EntityBase
    {
        protected DbContext _dbContext;
        protected readonly IDbSet<T> _dbSet;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            var entry = _dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
                _dbContext.Set<T>().Attach(entity);
            _dbContext.Set<T>().Remove(entity);

            //_dbContext.Set<T>().Remove(entity);
        }


        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).AsEnumerable();
        }

        public IEnumerable<T> DeleteAll()
        {
            return _dbContext.Set<T>();
        }

        public IEnumerable<T> DeleteAll(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().RemoveRange(_dbContext.Set<T>().Where(predicate).AsEnumerable());
        }

        public T GetById(TKey Id)// Guid id
        {
            return _dbContext.Set<T>().Find(Id); // id
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> UserSingUp()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> UserSingUp(Expression<Func<T, bool>> predicate)
        {
            return (IEnumerable<T>)_dbContext.Set<T>().FirstOrDefault();
        }
    }
}
