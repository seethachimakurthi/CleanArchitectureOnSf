

namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.AuditableEntity
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    public class AuditableEntityResponseDto:  ErrorDetail, IAuditableEntity
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
