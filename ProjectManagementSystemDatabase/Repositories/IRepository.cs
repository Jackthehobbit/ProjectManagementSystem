using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace ProjectManagementSystemDatabase.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> query);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> query);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
