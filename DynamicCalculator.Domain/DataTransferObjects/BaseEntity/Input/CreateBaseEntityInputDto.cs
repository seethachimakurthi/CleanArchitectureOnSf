namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.AuditableEntity.Input;
    public class CreateBaseEntityInputDto: CreateAuditableEntityInputDto
    {
        #region Implementation of IBaseEntity
        public Guid Id { get; set; }
        public bool IsValid { get; set; }
        #endregion
    }
}
