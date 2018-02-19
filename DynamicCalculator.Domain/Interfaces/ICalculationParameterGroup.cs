namespace Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    public interface ICalculationParameterGroup:IBaseEntity
    {

        string Name { get; set; }
        //ICollection<CalculationParameter> CalculationParameters { get; set; }
        
    }
}
