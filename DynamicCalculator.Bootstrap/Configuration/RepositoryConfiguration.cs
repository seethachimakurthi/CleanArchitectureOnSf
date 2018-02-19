namespace DynamicCalculator.Bootstrap.Configuration
{
    using System;
    //using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;
    //using Yajat.Digitalizer.DynamicCalculator.DataAccess.EF;
    //using Yajat.Digitalizer.DynamicCalculator.DataAccess.EF.Repository;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Configurations;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Constants;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;
    public static class RepositoryConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var connectionStrings = serviceProvider.GetService<IOptions<ConnectionStringsConfiguration>>();

            //services.AddDbContext<BaseContext>(options =>
            //{
            //    if (EnvironmentVariables.GetInMemoryDbValue()) { options.UseInMemoryDatabase("Onion.Pattern"); }
            //    else { options.UseSqlServer(connectionStrings.Value.VideoVariablesConnection); }
            //});
            //services.AddScoped<DbContext>(provider => provider.GetService<BaseContext>());

            //ConfigureNonAsync(services);
            //ConfigureAsync(services);
        }
/*
        private static void ConfigureNonAsync(IServiceCollection services)
        {
            services.AddTransient<IRepository<Variable>, Repository<Variable>>(InitializeReposiotry<Variable>());
            services.AddTransient<IRepository<Platform>, Repository<Platform>>(InitializeReposiotry<Platform>());
            services.AddTransient<IRepository<VariablePlatform>, Repository<VariablePlatform>>(InitializeReposiotry<VariablePlatform>());
            services.AddTransient<IRepositoryAggregate, RepositoryAggregate>();
        }

        private static void ConfigureAsync(IServiceCollection services)
        {
            services.AddTransient<IRepositoryAsync<Variable>, RepositoryAsync<Variable>>(InitializeReposiotryAsync<Variable>());
            services.AddTransient<IRepositoryAsync<Platform>, RepositoryAsync<Platform>>(InitializeReposiotryAsync<Platform>());
            services.AddTransient<IRepositoryAsync<VariablePlatform>, RepositoryAsync<VariablePlatform>>(InitializeReposiotryAsync<VariablePlatform>());
            services.AddTransient<IRepositoryAsyncAggregate, RepositoryAsyncAggregate>();
        }

        private static Func<IServiceProvider, Repository<TEntity>> InitializeReposiotry<TEntity>() where TEntity : BaseEntity
        {
            return context =>
            {
                DbContext dbContext = context.GetService<BaseContext>();
                return new Repository<TEntity>(dbContext);
            };
        }

        private static Func<IServiceProvider, RepositoryAsync<TEntity>> InitializeReposiotryAsync<TEntity>() where TEntity : BaseEntity
        {
            return context =>
            {
                DbContext dbContext = context.GetService<BaseContext>();
                return new RepositoryAsync<TEntity>(dbContext);
            };
        }
        */
    }
}
