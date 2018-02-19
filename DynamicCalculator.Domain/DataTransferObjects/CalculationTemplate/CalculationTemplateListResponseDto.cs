namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate
{
    using System.Collections.Generic;
    using System.Linq;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class CalculationTemplateListResponseDto : ErrorDetail, IListResponseDto
    {
        public IEnumerable<ICalculationTemplate> CalculationTemplates { get; set; } = new List<ICalculationTemplate>();

        #region Implementation of IListResponseDto

        public int Count => CalculationTemplates.Count();

        #endregion
    }
}
