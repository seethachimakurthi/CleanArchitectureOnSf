namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter
{
    using System.Collections.Generic;
    using System.Linq;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class CalculationParameterListResponseDto : ErrorDetail, IListResponseDto
    {
        public IEnumerable<ICalculationParameter> CalculationParameters { get; set; } = new List<ICalculationParameter>();

        #region Implementation of IListResponseDto

        public int Count => CalculationParameters.Count();

        #endregion
    }
}
