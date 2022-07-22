using System;
using System.Collections.Generic;
using System.Linq;
using Service.Interfaces;
using Models;
using System.Linq.Expressions;
using Repository.Interfaces;

namespace Service
{
    public class EntityService<TKey,T> : IEntityService<TKey, T> where T : EntityBase
    {
        IUnitOfWork _unitOfWork;
        IRepository<TKey,T> _repository;
        public EntityService(IUnitOfWork unitOfWork, IRepository<TKey, T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public void Create(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity == null");
            _repository.Create(entity);
            _unitOfWork.Save();
        }

        public void CreateMultipal(IEnumerable<T> entities)
        {
           if (entities == null) throw new ArgumentNullException("entities == null");
            if (!entities.Any()) throw new Exception("Последовательность не содержит элементов");
            foreach (T entity in entities)
            {
                _repository.Create(entity);
            }
            _unitOfWork.Save();
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Save();    
        }

        public IEnumerable<T> DeleteAll()
        {
            return _repository.DeleteAll();
        }

        public IEnumerable<T> DeleteAll(Expression<Func<T, bool>> predicate)
        {
            return _repository.DeleteAll(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
           return _repository.GetAll(predicate).ToList();
        }

        public T GetById(TKey Id)
        {
            return _repository.GetById(Id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Save();
        }
    }
}
