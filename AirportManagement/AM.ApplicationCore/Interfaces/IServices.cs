using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServices<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(params object[] keyValues);
        TEntity Get(Expression<Func<TEntity, bool>> where);//Recherche avec condition 
        void Delete(Expression<Func<TEntity, bool>> where);//Delete by condition
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);//GetAll avec condition
        public void commit();
    }
}
