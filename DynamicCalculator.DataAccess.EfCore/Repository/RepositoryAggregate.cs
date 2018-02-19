namespace Yajat.Digitalizer.DynamicCalculator.DataAccess.EfCore.Repository
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;

    public class RepositoryAggregate : IRepositoryAggregate
    {
        private readonly DbContext dbContext;

        public RepositoryAggregate(DbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException($"{nameof(dbContext)} cannot be null.");
        }

        private IRepository<Variable> variables;
        public IRepository<Variable> Variables => variables ?? (variables = new Repository<Variable>(dbContext));

        public IRepository<ApplicableItem> ApplicableItems => throw new NotImplementedException();

        public IRepository<ApplicableItemGroup> ApplicableItemGroups => throw new NotImplementedException();

        public IRepository<CalculationParameter> CalculationParameters => throw new NotImplementedException();

        public IRepository<CalculationParameterGroup> CalculationParameterGroups => throw new NotImplementedException();

        public IRepository<CalculationPeriod> CalculationPeriods => throw new NotImplementedException();

        public IRepository<CalculationTemplate> CalculationTemplates => throw new NotImplementedException();

        public IRepository<ResultTransformer> Transformers => throw new NotImplementedException();
    }
}
