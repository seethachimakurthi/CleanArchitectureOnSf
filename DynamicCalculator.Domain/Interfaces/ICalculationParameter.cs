namespace Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces
{
    public interface ICalculationParameter:IBaseEntity
    {
        string Name { get; set; }
        string EquiavalentValue { get; set; }

    }
}
