﻿

namespace Yajat.Digitalizer.DynamicCalculator.Service.Requests
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;

    /// <summary>
    /// Each Request requires a Repository and A Repository Aggregate.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class BaseRequestAggregate<TEntity> where TEntity : BaseEntity
    {
        protected IRepository<TEntity> Repository { get; }
        protected IRepositoryAggregate RepositoryAggregate { get; }

        /// <exception cref="ArgumentNullException">Condition.</exception>
        protected BaseRequestAggregate(IRepository<TEntity> repository, IRepositoryAggregate repositoryAggregate)
        {
            Repository = repository ?? throw new ArgumentNullException($"{nameof(repository)} cannot be null.");
            RepositoryAggregate = repositoryAggregate ?? throw new ArgumentNullException($"{nameof(repositoryAggregate)} cannot be null.");
        }
    }
}
