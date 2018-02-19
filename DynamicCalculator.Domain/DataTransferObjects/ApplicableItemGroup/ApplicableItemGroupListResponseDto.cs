namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup
{
    using System.Collections.Generic;
    using System.Linq;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class ApplicableItemGroupListResponseDto : ErrorDetail, IListResponseDto
    {
        public IEnumerable<IApplicableItemGroup> ApplicableItemGroups { get; set; } = new List<IApplicableItemGroup>();

        #region Implementation of IListResponseDto

        public int Count => ApplicableItemGroups.Count();

        #endregion
    }
}
