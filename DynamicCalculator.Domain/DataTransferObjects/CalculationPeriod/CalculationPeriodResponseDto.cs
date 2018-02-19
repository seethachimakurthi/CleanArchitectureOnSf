namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity;
    using System;

    public class CalculationPeriodResponseDto : BaseEntityResponseDto, ICalculationPeriod
    {
        #region Implementation of ICalculationPeriod
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        #endregion
    }
}