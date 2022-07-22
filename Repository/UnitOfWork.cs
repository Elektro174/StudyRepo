using Repository.Interfaces;
using System;
using System.Data.Entity;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }
        /// <summary>
        /// Сохранить изменения
        /// </summary>
        /// <returns></returns>
        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
