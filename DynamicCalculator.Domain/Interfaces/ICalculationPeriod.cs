namespace Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces
{
    using System;
    public interface ICalculationPeriod: IBaseEntity
    {
         DateTime StartDate { get; set; }
         DateTime EndDate { get; set; }
         //CalculationTemplate CalculationTemplate { get; set; }

    }
}
