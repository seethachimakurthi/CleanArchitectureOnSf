namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod
{
    using System.Collections.Generic;
    using System.Linq;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class CalculationPeriodListResponseDto : ErrorDetail, IListResponseDto
    {
        public IEnumerable<ICalculationPeriod> CalculationPeriods { get; set; } = new List<ICalculationPeriod>();

        #region Implementation of IListResponseDto

        public int Count => CalculationPeriods.Count();

        #endregion
    }
}
