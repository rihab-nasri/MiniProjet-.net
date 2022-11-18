using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class Service<TEntity> : IServices<TEntity> where TEntity : class
    {
        private IGenericRepository<TEntity> _repository;
        private IUnitOfWork _unitOfWork;
        public Service( IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.Repository<TEntity>();
            _unitOfWork = unitOfWork;
        }

        public void Add(TEntity entity)
        {
         _repository.Add(entity);
        }

        public void commit()
        {
            _unitOfWork.Save();
        }

        public void Delete(TEntity entity)
        {
           _repository.Delete(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            _repository.Delete(where );
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return _repository.Get(where);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(params object[] keyValues)
        {
            return _repository.GetById(keyValues);
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return _repository.GetMany(where);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
