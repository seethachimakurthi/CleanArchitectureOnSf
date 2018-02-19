namespace Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public interface IVariable: IBaseEntity
    {
        string Name { get; set; }

       
        string DefaultValue { get; set; }

        string Definition { get; set; }

        int Priority { get; set; }
       
        string RangeStart { get; set; }
       
        string RangeEnd { get; set; }
    }
}
