namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    [Table("ResultTransformer")]
    public class ResultTransformer : BaseEntity, IResultTransformer
    {
        public double StartValue { get; set; }
        public double EndValue { get; set; }
        public double EquiavalentValue { get; set; }        
        public virtual CalculationPeriod CalculationPeriod { get; set; }
       
    }
}
