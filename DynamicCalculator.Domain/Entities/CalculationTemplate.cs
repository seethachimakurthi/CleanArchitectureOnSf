namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    public class CalculationTemplate : BaseEntity,ICalculationTemplate
    {
         
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
       
        public ICollection<CalculationParameterGroup> CalculationParameterGroups { get; set; }

        public ICollection<ApplicableItemGroup> ApplicableItemGroups { get; set; }
        public ICollection<IVariable> Variables { get; set; }

       
        public virtual CalculationPeriod CalculationPeriod { get; set; }

    }
}
