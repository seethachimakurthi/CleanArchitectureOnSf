namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem
{
    using System.Collections.Generic;
    using System.Linq;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class ApplicableItemListResponseDto : ErrorDetail, IListResponseDto
    {
        public IEnumerable<IApplicableItem> ApplicableItems { get; set; } = new List<IApplicableItem>();

        #region Implementation of IListResponseDto

        public int Count => ApplicableItems.Count();

        #endregion
    }
}
