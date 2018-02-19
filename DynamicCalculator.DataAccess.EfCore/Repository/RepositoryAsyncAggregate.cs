namespace Yajat.Digitalizer.DynamicCalculator.DataAccess.EfCore.Repository
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;

    public class RepositoryAsyncAggregate : IRepositoryAsyncAggregate
    {
        private readonly DbContext dbContext;

        public RepositoryAsyncAggregate(DbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException($"{nameof(dbContext)} cannot be null.");
        }

        private IRepositoryAsync<Variable> variables;
        public IRepositoryAsync<Variable> Variables => variables ?? (variables = new RepositoryAsync<Variable>(dbContext));

        public IRepositoryAsync<ApplicableItem> ApplicableItems => throw new NotImplementedException();

        public IRepositoryAsync<ApplicableItemGroup> ApplicableItemGroups => throw new NotImplementedException();

        public IRepositoryAsync<CalculationParameter> CalculationParameters => throw new NotImplementedException();

        public IRepositoryAsync<CalculationParameterGroup> CalculationParameterGroups => throw new NotImplementedException();

        public IRepositoryAsync<CalculationTemplate> CalculationTemplates => throw new NotImplementedException();

        
    }
}
