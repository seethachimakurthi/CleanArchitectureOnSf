namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class ApplicableItem : BaseEntity, IApplicableItem
    {
       
        [MaxLength(100)]
        
        public string Parameter1 { get; set; }

        [StringLength(100)]
       
        public string Parameter2 { get; set; }

        [StringLength(100)]
       
        public string Parameter3 { get; set; }

       
        public virtual ApplicableItemGroup ApplicableItemGroup { get; set; }
        
    }
}
