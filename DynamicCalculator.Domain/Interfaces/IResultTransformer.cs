namespace Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces
{
    public interface IResultTransformer : IBaseEntity
    {
         double StartValue { get; set; }
         double EndValue { get; set; }
         double EquiavalentValue { get; set; }
    }
}