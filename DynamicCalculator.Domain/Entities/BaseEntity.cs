namespace Yajat.Digitalizer.DynamicCalculator.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Validations;
    public abstract class BaseEntity: AuditableEntity,IBaseEntity
    {
        public Guid Id { get; set; }
        public bool IsValid { get; set; } = true;

        public ICollection<ValidationError> ValidationErrors { get; set; }
    }
}
