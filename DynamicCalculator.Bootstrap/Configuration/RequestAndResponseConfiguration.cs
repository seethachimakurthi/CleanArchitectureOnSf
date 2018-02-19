namespace DynamicCalculator.Bootstrap.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable;   
    //using Yajat.Digitalizer.DynamicCalculator.Service.Requests.Variable;
    //using Yajat.Digitalizer.DynamicCalculator.Service.Requests.Variable.Async;
    //using Yajat.Digitalizer.DynamicCalculator.Service.Requests.Platform;
    //using Yajat.Digitalizer.DynamicCalculator.Service.Requests.Platform.Async;
    using System;
    public static class RequestAndResponsesConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            //ConfigureVariableRequestAggregates(services);
            //ConfigurePlatformAggregate(services);
        }

        //private static void ConfigureVariableRequestAggregates(IServiceCollection services)
        //{
        //    services.AddTransient<IVariableRequestAggregate>(context =>
        //    {
        //        var dependencies = GetRequestDependencies<Variable>(context);
        //        return new VariableRequestAggregate(dependencies.Repository, dependencies.RepositoryAggregate);
        //    });

        //    services.AddTransient<IVariableRequestAggregateAsync>(context =>
        //    {
        //        var dependencies = GetRequestAsyncDependencies<Variable>(context);
        //        return new VariableRequestAsyncAggregate(dependencies.Repository, dependencies.RepositoryAggregate);
        //    });
        //}

        //private static void ConfigurePlatformAggregate(IServiceCollection services)
        //{
        //    #region Non-Async
        //    services.AddTransient<IPlatformRequestAggregate>(context =>
        //    {
        //        var dependencies = GetRequestDependencies<Platform>(context);
        //        return new PlatformRequestAggregate(dependencies.Repository, dependencies.RepositoryAggregate);
        //    });
        //    #endregion Non-Async

        //    #region Async
        //    services.AddTransient<IPlatformRequestAsyncAggregate>(context =>
        //    {
        //        var asyncDependencies = GetRequestAsyncDependencies<Platform>(context);
        //        return new PlatformRequestAsyncAggregate(asyncDependencies.Repository, asyncDependencies.RepositoryAggregate);
        //    });
        //    #endregion Async
        //}

        #region Get Dependency Methods

        private static (IRepository<TEntity> Repository, IRepositoryAggregate RepositoryAggregate) GetRequestDependencies<TEntity>(IServiceProvider context) where TEntity : BaseEntity
        {
            var repository = context.GetService<IRepository<TEntity>>();
            var repositoryAggregate = context.GetService<IRepositoryAggregate>();

            return (repository, repositoryAggregate);
        }

        private static (IRepositoryAsync<TEntity> Repository, IRepositoryAsyncAggregate RepositoryAggregate) GetRequestAsyncDependencies<TEntity>(IServiceProvider context) where TEntity : BaseEntity
        {
            var repository = context.GetService<IRepositoryAsync<TEntity>>();
            var repositoryAggregate = context.GetService<IRepositoryAsyncAggregate>();

            return (repository, repositoryAggregate);
        }

        #endregion Get Dependency Methods
    }
}
