namespace Yajat.Digitalizer.DynamicCalculator.Domain.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity Single(Expression<Func<TEntity, bool>> expression);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> expression);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
    }
}
