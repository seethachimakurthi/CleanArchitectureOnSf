namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem.Input
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input;
    public class CreateApplicableItemInputDto : CreateBaseEntityInputDto
    {
        #region Implementation of IApplicableItem
        public string Parameter1 { get; set; }



        public string Parameter2 { get; set; }


        public string Parameter3 { get; set; }
        #endregion
    }
}
