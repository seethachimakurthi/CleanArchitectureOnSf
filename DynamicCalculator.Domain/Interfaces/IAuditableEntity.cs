using System;

namespace Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces
{
    public interface IAuditableEntity 
    {
        String CreatedBy { get; set; }

        DateTime? CreatedAt { get; set; }

        String UpdatedBy { get; set; }

        DateTime? UpdatedAt { get; set; }
    }
}
