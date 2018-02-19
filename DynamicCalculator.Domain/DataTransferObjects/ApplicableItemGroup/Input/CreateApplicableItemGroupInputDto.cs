namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup.Input
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input;
    public class CreateApplicableItemGroupInputDto : CreateBaseEntityInputDto
    {
        #region Implementation of IApplicableItemGroup
        public string Name { get; set; }
        #endregion
    }
}
