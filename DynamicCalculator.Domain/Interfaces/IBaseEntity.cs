namespace Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Validations;
    public interface IBaseEntity:IAuditableEntity
    {
         Guid Id { get; set; }
         bool IsValid { get; set; }
        
    }
}
