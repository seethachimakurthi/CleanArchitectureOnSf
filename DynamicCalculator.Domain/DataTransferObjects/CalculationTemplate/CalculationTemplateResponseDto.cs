namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity;
    using System;

    public class CalculationTemplateResponseDto : BaseEntityResponseDto, ICalculationTemplate
    {
        #region Implementation of ICalculationTemplate
        public string Name { get; set; }
        #endregion
    }
}