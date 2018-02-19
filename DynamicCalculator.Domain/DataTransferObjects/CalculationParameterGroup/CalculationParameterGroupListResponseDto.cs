namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup
{
    using System.Collections.Generic;
    using System.Linq;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class CalculationParameterGroupListResponseDto : ErrorDetail, IListResponseDto
    {
        public IEnumerable<ICalculationParameterGroup> CalculationParameterGroups { get; set; } = new List<ICalculationParameterGroup>();

        #region Implementation of IListResponseDto

        public int Count => CalculationParameterGroups.Count();

        #endregion
    }
}
