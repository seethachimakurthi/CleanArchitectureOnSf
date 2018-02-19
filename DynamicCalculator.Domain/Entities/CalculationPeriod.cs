namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class CalculationPeriod: BaseEntity, ICalculationPeriod
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CalculationTemplate CalculationTemplate { get; set; }

        public ICollection<ResultTransformer> Ranges { get; set; }
       
       //// public virtual Market Market { get; set; }
        
    }
}
