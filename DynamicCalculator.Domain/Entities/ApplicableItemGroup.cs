namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class ApplicableItemGroup : BaseEntity, IApplicableItemGroup
    {
        [Required]
        [MaxLength(100)]        
        public string Name { get; set; }

        public ICollection<ApplicableItem> ApplicableItems { get; set; }
        
        public virtual CalculationTemplate CalculationTemplate { get; set; }
    }
}
