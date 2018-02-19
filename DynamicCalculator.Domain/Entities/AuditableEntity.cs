namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class AuditableEntity : IAuditableEntity
    {               
       
       
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy  { get; set; }
        
    }
}
