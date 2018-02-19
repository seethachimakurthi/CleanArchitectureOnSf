namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CalculationParameterGroup: BaseEntity, ICalculationParameterGroup
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public ICollection<CalculationParameter> CalculationParameters { get; set; }

       
        public virtual CalculationTemplate CalculationTemplate { get; set; }
       
    }
}
