namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    [Table("CalculationParameters")]
    public class CalculationParameter: BaseEntity, ICalculationParameter
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string EquiavalentValue { get; set; }

        
        public virtual CalculationParameterGroup CalculationParameterGroup { get; set; }
       
    }
}
