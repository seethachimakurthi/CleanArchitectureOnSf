using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;

namespace Yajat.Digitalizer.DynamicCalculator.Domain.Repository
{
    public interface IRepositoryAsyncAggregate
    {
        IRepositoryAsync<ApplicableItem> ApplicableItems { get; }
        IRepositoryAsync<ApplicableItemGroup> ApplicableItemGroups { get; }
        IRepositoryAsync<CalculationParameter> CalculationParameters { get; }
        IRepositoryAsync<CalculationParameterGroup> CalculationParameterGroups { get; }
        //IRepository<CalculationPeriod> ApplicableItems { get; }
        IRepositoryAsync<CalculationTemplate> CalculationTemplates { get; }
        IRepositoryAsync<Variable> Variables { get; }
        //IRepository<ResultTransformer> Transformers { get; }
        
    }
}
