namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity;
    public class ApplicableItemGroupResponseDto : BaseEntityResponseDto, IApplicableItemGroup
    {
        #region Implementation of IApplicableItemGroup
        public string Name { get; set; }
        #endregion
    }
}
