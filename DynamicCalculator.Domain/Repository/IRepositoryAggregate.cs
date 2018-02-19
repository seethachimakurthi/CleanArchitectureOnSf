using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;

namespace Yajat.Digitalizer.DynamicCalculator.Domain.Repository
{
    public interface IRepositoryAggregate
    {
        IRepository<ApplicableItem> ApplicableItems { get; }
        IRepository<ApplicableItemGroup> ApplicableItemGroups { get; }
        IRepository<CalculationParameter> CalculationParameters { get; }
        IRepository<CalculationParameterGroup> CalculationParameterGroups { get; }
        IRepository<CalculationPeriod> CalculationPeriods { get; }
        IRepository<CalculationTemplate> CalculationTemplates { get; }
        IRepository<Variable> Variables { get; }
        IRepository<ResultTransformer> Transformers { get; }
        
    }
}
