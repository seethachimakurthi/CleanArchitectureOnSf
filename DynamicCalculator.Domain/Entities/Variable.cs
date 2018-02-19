namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Variable : BaseEntity
    {
        [Required]
        [MaxLength(100)]        
        public string Name { get; set; }
        
        [MaxLength(30)]       
        public string DefaultValue { get; set; }
                
        public string Definition { get; set; }

        public int Priority { get; set; }
        [MaxLength(30)]
        public string RangeStart { get; set; }
        [MaxLength(30)]
        public string RangeEnd { get; set; }
        public virtual CalculationTemplate CalculationTemplate { get; set; }


    }
}
