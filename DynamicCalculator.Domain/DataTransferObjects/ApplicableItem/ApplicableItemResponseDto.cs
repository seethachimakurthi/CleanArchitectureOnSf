namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity;
    public class ApplicableItemResponseDto : BaseEntityResponseDto, IApplicableItem
    {
        #region Implementation of IApplicableItem
        public string Parameter1 { get; set; }



        public string Parameter2 { get; set; }


        public string Parameter3 { get; set; }
        #endregion
    }
}
