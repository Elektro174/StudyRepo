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
    public class Repository<T> : IRepository<T> where T : EntityBase
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
            _dbContext.Set<T>().Remove(entity);
        }
    

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).AsEnumerable();
        }

        public T GetById(int Id)// Guid id
        {
            return _dbContext.Set<T>().Find(Id); // id
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
