﻿

namespace DynamicCalculator.DataAccess.Service
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.DataAccess.Service;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;

    /// <summary>
    ///  Each service request requires a Repository Async and Repository Aggregate Async.
    /// </summary>
    /// <typeparam name="TEntity">Type of Repositories to conenct to.</typeparam>
    public abstract class BaseServiceRequestAsync<TEntity> : ServiceHandleError where TEntity : BaseEntity
    {
        protected IRepositoryAsync<TEntity> Repository { get; }
        protected IRepositoryAsyncAggregate RepositoryAggregate { get; }

        /// <exception cref="ArgumentNullException">Condition.</exception>
        protected BaseServiceRequestAsync(IRepositoryAsync<TEntity> repository, IRepositoryAsyncAggregate repositoryAggregate)
        {
            Repository = repository ?? throw new ArgumentNullException($"{nameof(repository)} cannot be null.");
            RepositoryAggregate = repositoryAggregate ?? throw new ArgumentNullException($"{nameof(repositoryAggregate)} cannot be null.");
        }
    }
}
