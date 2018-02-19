

namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.AuditableEntity;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    public class BaseEntityResponseDto:  AuditableEntityResponseDto, IBaseEntity
    {
        public Guid Id { get; set; }
        public bool IsValid { get; set; } = true;
    }
}
